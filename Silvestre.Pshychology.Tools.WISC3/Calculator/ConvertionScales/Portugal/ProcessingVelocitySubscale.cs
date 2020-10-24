using System.Collections.Generic;
using System.Linq;

namespace Silvestre.Pshychology.Tools.WISC3.Calculator.ConvertionScales.Portugal
{
    internal class ProcessingVelocitySubscale : ConvertionScaleByLookup
    {
        private static readonly IDictionary<short, (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95)> _lookupTable = new Dictionary<short, (short, decimal, (short, short), (short, short))>
        {
            { 2,  (50,  0m,     (52, 70),   (50, 72)) },
            { 3,  (51,  0.1m,   (53, 71),   (51, 73)) },
            { 4,  (53,  0.1m,   (54, 72),   (53, 74)) },
            { 5,  (54,  0.1m,   (55, 73),   (53, 75)) },
            { 6,  (57,  0.2m,   (57, 76),   (56, 77)) },
            { 7,  (59,  0.3m,   (59, 77),   (57, 79)) },
            { 8,  (63,  0.7m,   (62, 80),   (60, 82)) },
            { 9,  (67,  1m,     (65, 83),   (63, 85)) },
            { 10, (71,  3m,     (68, 86),   (67, 88)) },
            { 11, (74,  4m,     (71, 89),   (69, 91)) },
            { 12, (77,  6m,     (73, 91),   (71, 93)) },
            { 13, (81,  10m,    (76, 94),   (74, 96)) },
            { 14, (84,  14m,    (78, 97),   (77, 98)) },
            { 15, (86,  18m,    (80, 98),   (78, 100)) },
            { 16, (89,  23m,    (82, 101),  (81, 102)) },
            { 17, (92,  30m,    (85, 103),  (83, 105)) },
            { 18, (95,  37m,    (87, 105),  (85, 107)) },
            { 19, (97,  42m,    (89, 107),  (87, 108)) },
            { 20, (100, 50m,    (91, 109),  (89, 111)) },
            { 21, (103, 58m,    (93, 111),  (92, 113)) },
            { 22, (106, 65m,    (96, 114),  (94, 115)) },
            { 23, (109, 72m,    (98, 116),  (96, 118)) },
            { 24, (112, 79m,    (100, 118), (99, 120)) },
            { 25, (114, 82m,    (102, 120), (100, 122)) },
            { 26, (117, 87m,    (104, 122), (102, 124)) },
            { 27, (119, 90m,    (106, 124), (104, 126)) },
            { 28, (122, 93m,    (108, 126), (106, 128)) },
            { 29, (125, 95m,    (111, 129), (109, 130)) },
            { 30, (128, 97m,    (113, 131), (111, 133)) },
            { 31, (131, 98m,    (115, 133), (113, 135)) },
            { 32, (134, 99m,    (117, 136), (116, 137)) },
            { 33, (137, 99.3m,  (120, 138), (118, 140)) },
            { 34, (141, 99.7m,  (123, 141), (121, 143)) },
            { 35, (145, 99.9m,  (126, 144), (124, 146)) },
            { 36, (147, 99.9m,  (128, 146), (126, 148)) },
            { 37, (149, 99.9m,  (129, 147), (127, 149)) },
            { 38, (150, 100m,   (130, 148), (128, 150)) }
        };

        protected internal override IDictionary<short, (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95)> LookupTable => _lookupTable;

        protected override (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95)? OnResultOutOfBounds(short results)
        {
            var maxValue = this.LookupTable.Keys.Max();
            return this.LookupTable[maxValue];
        }
    }
}