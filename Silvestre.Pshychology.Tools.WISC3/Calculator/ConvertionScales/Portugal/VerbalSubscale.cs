﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvestre.Pshychology.Tools.WISC3.Calculator.ConvertionScales.Portugal
{
    internal class VerbalSubscale : ConvertionScaleByLookup
    {
        private static readonly IDictionary<short, (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95)> _lookupTable = new Dictionary<short, (short, decimal, (short, short), (short, short))>
        {
            { 5,  (46,  0m,     (44, 56),    (43, 57)) },
            { 6,  (47,  0m,     (45, 57),    (44, 58)) },
            { 7,  (47,  0m,     (45, 57),    (44, 58)) },
            { 8,  (48,  0m,     (46, 58),    (44, 59)) },
            { 9,  (49,  0m,     (46, 59),    (45, 60)) },
            { 10, (50,  0m,     (47, 60),    (46, 61)) },
            { 11, (51,  0.1m,   (48, 61),    (47, 62)) },
            { 12, (52,  0.1m,   (49, 61),    (48, 63)) },
            { 13, (53,  0.1m,   (50, 62),    (49, 63)) },
            { 14, (54,  0.1m,   (51, 63),    (50, 64)) },
            { 15, (56,  0.2m,   (53, 65),    (52, 66)) },
            { 16, (57,  0.2m,   (54, 66),    (53, 67)) },
            { 17, (58,  0.3m,   (55, 67),    (54, 68)) },
            { 18, (59,  0.3m,   (56, 68),    (55, 69)) },
            { 19, (60,  0.4m,   (57, 69),    (56, 70)) },
            { 20, (61,  0.5m,   (58, 70),    (57, 71)) },
            { 21, (62,  0.6m,   (59, 71),    (57, 72)) },
            { 22, (63,  0.7m,   (59, 72),    (58, 73)) },
            { 23, (64,  0.8m,   (60, 73),    (59, 74)) },
            { 24, (65,  1m,     (61, 74),    (60, 75)) },
            { 25, (66,  1m,     (62, 74),    (61, 76)) },
            { 26, (66,  1m,     (62, 74),    (61, 76)) },
            { 27, (67,  1m,     (63, 75),    (62, 77)) },
            { 28, (68,  2m,     (64, 76),    (63, 77)) },
            { 29, (69,  2m,     (65, 77),    (64, 78)) },
            { 30, (70,  2m,     (66, 78),    (65, 79)) },
            { 31, (72,  3m,     (68, 80),    (67, 81)) },
            { 32, (73,  4m,     (69, 81),    (68, 82)) },
            { 33, (75,  5m,     (71, 83),    (70, 84)) },
            { 34, (76,  6m,     (72, 84),    (70, 85)) },
            { 35, (78,  7m,     (73, 86),    (72, 87)) },
            { 36, (80,  9m,     (75, 88),    (74, 89)) },
            { 37, (81,  10m,    (76, 88),    (75, 90)) },
            { 38, (82,  12m,    (77, 89),    (76, 90)) },
            { 39, (84,  14m,    (79, 91),    (78, 92)) },
            { 40, (86,  18m,    (81, 93),    (80, 94)) },
            { 41, (87,  19m,    (82, 94),    (81, 95)) },
            { 42, (89,  23m,    (84, 96),    (83, 97)) },
            { 43, (91,  27m,    (86, 98),    (84, 99)) },
            { 44, (92,  30m,    (86, 99),    (85, 100)) },
            { 45, (93,  32m,    (87, 100),   (86, 101)) },
            { 46, (94,  34m,    (88, 101),   (87, 102)) },
            { 47, (96,  39m,    (90, 102),   (89, 103)) },
            { 48, (97,  42m,    (91, 103),   (90, 104)) },
            { 49, (99,  47m,    (93, 105),   (92, 106)) },
            { 50, (100, 50m,    (94, 106),   (93, 107)) },
            { 51, (101, 53m,    (95, 107),   (94, 108)) },
            { 52, (102, 55m,    (96, 108),   (95, 109)) },
            { 53, (104, 61m,    (98, 110),   (97, 111)) },
            { 54, (105, 63m,    (99, 111),   (97, 112)) },
            { 55, (106, 65m,    (99, 112),   (98, 113)) },
            { 56, (108, 70m,    (101, 114),  (100, 115)) },
            { 57, (109, 73m,    (102, 114),  (101, 116)) },
            { 58, (110, 75m,    (103, 115),  (102, 117)) },
            { 59, (111, 77m,    (104, 116),  (103, 117)) },
            { 60, (112, 79m,    (105, 117),  (104, 118)) },
            { 61, (113, 81m,    (106, 118),  (105, 119)) },
            { 62, (115, 84m,    (108, 120),  (107, 121)) },
            { 63, (116, 86m,    (109, 121),  (108, 122)) },
            { 64, (117, 87m,    (110, 122),  (109, 123)) },
            { 65, (118, 88m,    (111, 123),  (110, 124)) },
            { 66, (120, 91m,    (113, 125),  (111, 126)) },
            { 67, (121, 92m,    (113, 126),  (112, 127)) },
            { 68, (122, 93m,    (114, 127),  (113, 128)) },
            { 69, (124, 94m,    (116, 128),  (115, 130)) },
            { 70, (125, 95m,    (117, 129),  (116, 130)) },
            { 71, (126, 96m,    (118, 130),  (117, 131)) },
            { 72, (127, 96m,    (119, 131),  (118, 132)) },
            { 73, (129, 97m,    (121, 133),  (120, 134)) },
            { 74, (130, 98m,    (122, 134),  (121, 135)) },
            { 75, (131, 98m,    (123, 135),  (122, 136)) },
            { 76, (133, 99m,    (125, 137),  (123, 138)) },
            { 77, (135, 99m,    (126, 139),  (125, 140)) },
            { 78, (137, 99.3m,  (128, 141),  (127, 142)) },
            { 79, (138, 99.4m,  (129, 141),  (128, 143)) },
            { 80, (139, 99.5m,  (130, 142),  (129, 143)) },
            { 81, (141, 99.6m,  (132, 144),  (131, 145)) },
            { 82, (142, 99.8m,  (133, 145),  (132, 146)) },
            { 83, (143, 99.8m,  (134, 146),  (133, 147)) },
            { 84, (144, 99.9m,  (135, 147),  (134, 148)) },
            { 85, (145, 99.9m,  (136, 148),  (135, 149)) },
            { 86, (146, 99.9m,  (137, 149),  (136, 150)) },
            { 87, (147, 99.9m,  (138, 150),  (137, 151)) },
            { 88, (148, 99.9m,  (139, 151),  (137, 152)) },
            { 89, (149, 99.9m,  (139, 152),  (138, 153)) },
            { 90, (150, 100m,   (140, 153),  (139, 154)) },
            { 91, (151, 100m,   (141, 154),  (140, 155)) },
            { 92, (152, 100m,   (142, 154),  (141, 156)) },
            { 93, (153, 100m,   (143, 155),  (142, 156)) },
            { 94, (154, 100m,   (144, 156),  (143, 157)) },
            { 95, (155, 100m,   (145, 157),  (144, 158)) }
        };

        protected internal override IDictionary<short, (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95)> LookupTable => _lookupTable;

        protected override (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95)? OnResultOutOfBounds(short results)
        {
            var maxValue = this.LookupTable.Keys.Max();
            return this.LookupTable[maxValue];
        }
    }
}
