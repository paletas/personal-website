using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class ThirteenYearSixMonthLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 7 => 1,
                8 => 2,
                9 => 3,
                10 => 4,
                11 => 5,
                12 => 7,
                var r when r >= 13 && r <= 14 => 8,
                15 => 9,
                16 => 10,
                17 => 11,
                18 => 12,
                19 => 13,
                20 => 14,
                21 => 15,
                22 => 16,
                23 => 17,
                24 => 18,
                var r when r >= 25 && r <= 30 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetCodeDescriptor()
        {
            return new TestDescriptorPerAge((0, 119));
        }

        public short GetCodeStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 28 => 1,
                var r when r >= 29 && r <= 34 => 2,
                var r when r >= 35 && r <= 37 => 3,
                var r when r >= 38 && r <= 39 => 4,
                var r when r >= 40 && r <= 44 => 5,
                var r when r >= 45 && r <= 47 => 6,
                var r when r >= 48 && r <= 52 => 7,
                var r when r >= 53 && r <= 55 => 8,
                var r when r >= 56 && r <= 60 => 9,
                var r when r >= 61 && r <= 63 => 10,
                var r when r >= 64 && r <= 67 => 11,
                var r when r >= 68 && r <= 72 => 12,
                var r when r >= 73 && r <= 75 => 13,
                var r when r >= 76 && r <= 77 => 14,
                var r when r >= 78 && r <= 80 => 15,
                var r when r >= 81 && r <= 83 => 16,
                var r when r >= 84 && r <= 86 => 17,
                var r when r >= 87 && r <= 90 => 18,
                var r when r >= 91 && r <= 119 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetComprehensionDescriptor()
        {
            return new TestDescriptorPerAge((0, 36));
        }

        public short GetComprehensionStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 7 => 1,
                var r when r >= 8 && r <= 10 => 2,
                11 => 3,
                12 => 5,
                13 => 6,
                var r when r >= 14 && r <= 15 => 7,
                var r when r >= 16 && r <= 17 => 8,
                18 => 9,
                19 => 10,
                var r when r >= 20 && r <= 21 => 11,
                22 => 12,
                var r when r >= 23 && r <= 24 => 13,
                25 => 14,
                26 => 15,
                27 => 16,
                28 => 17,
                29 => 18,
                var r when r >= 30 && r <= 36 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetCubesDescriptor()
        {
            return new TestDescriptorPerAge((0, 69));
        }

        public short GetCubesStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 16 => 1,
                var r when r >= 17 && r <= 21 => 2,
                var r when r >= 22 && r <= 25 => 3,
                var r when r >= 26 && r <= 29 => 4,
                var r when r >= 30 && r <= 32 => 5,
                var r when r >= 33 && r <= 37 => 6,
                var r when r >= 38 && r <= 41 => 7,
                var r when r >= 42 && r <= 45 => 8,
                var r when r >= 46 && r <= 48 => 9,
                var r when r >= 49 && r <= 51 => 10,
                var r when r >= 52 && r <= 55 => 11,
                var r when r >= 56 && r <= 58 => 12,
                var r when r >= 59 && r <= 60 => 13,
                var r when r >= 61 && r <= 62 => 14,
                var r when r >= 63 && r <= 64 => 15,
                var r when r >= 65 && r <= 66 => 16,
                67 => 17,
                68 => 18,
                69 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetDigitMemoryDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetDigitMemoryStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 6 => 1,
                7 => 2,
                8 => 3,
                9 => 5,
                10 => 6,
                11 => 7,
                12 => 8,
                13 => 9,
                14 => 10,
                15 => 11,
                16 => 12,
                var r when r >= 17 && r <= 18 => 13,
                19 => 14,
                20 => 15,
                21 => 16,
                22 => 17,
                23 => 18,
                var r when r >= 24 && r <= 30 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetImageCompletionDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetImageCompletionStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 12 => 1,
                13 => 2,
                14 => 3,
                15 => 4,
                16 => 5,
                17 => 6,
                var r when r >= 18 && r <= 19 => 7,
                20 => 8,
                21 => 9,
                22 => 10,
                23 => 12,
                24 => 13,
                25 => 14,
                26 => 16,
                27 => 17,
                var r when r >= 28 && r <= 29 => 18,
                30 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetImageDispositionDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetImageDispositionStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 12 => 2,
                var r when r >= 13 && r <= 15 => 3,
                var r when r >= 16 && r <= 18 => 4,
                var r when r >= 19 && r <= 21 => 5,
                var r when r >= 22 && r <= 24 => 6,
                var r when r >= 25 && r <= 27 => 7,
                var r when r >= 28 && r <= 30 => 8,
                var r when r >= 31 && r <= 34 => 9,
                var r when r >= 35 && r <= 36 => 10,
                var r when r >= 37 && r <= 40 => 11,
                var r when r >= 41 && r <= 43 => 12,
                var r when r >= 44 && r <= 45 => 13,
                var r when r >= 46 && r <= 47 => 14,
                var r when r >= 48 && r <= 50 => 15,
                var r when r >= 51 && r <= 52 => 16,
                var r when r >= 53 && r <= 54 => 17,
                var r when r >= 55 && r <= 56 => 18,
                var r when r >= 57 && r <= 64 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetInformationDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetInformationStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 9 => 1,
                10 => 2,
                11 => 3,
                var r when r >= 12 && r <= 13 => 4,
                14 => 5,
                15 => 6,
                16 => 7,
                17 => 8,
                var r when r >= 18 && r <= 19 => 9,
                20 => 10,
                21 => 11,
                22 => 12,
                23 => 13,
                24 => 14,
                25 => 15,
                26 => 16,
                27 => 17,
                28 => 18,
                var r when r >= 29 && r <= 30 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetLabyrinthDescriptor()
        {
            return new TestDescriptorPerAge((0, 28));
        }

        public short GetLabyrinthStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 9 => 1,
                var r when r >= 10 && r <= 11 => 2,
                12 => 3,
                var r when r >= 13 && r <= 14 => 4,
                15 => 5,
                16 => 6,
                var r when r >= 17 && r <= 18 => 7,
                19 => 8,
                var r when r >= 20 && r <= 21 => 9,
                22 => 10,
                23 => 11,
                24 => 12,
                25 => 13,
                26 => 14,
                27 => 15,
                28 => 16,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetObjectCompositionDescriptor()
        {
            return new TestDescriptorPerAge((0, 44));
        }

        public short GetObjectCompositionStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 14 => 1,
                var r when r >= 15 && r <= 16 => 2,
                var r when r >= 17 && r <= 18 => 3,
                var r when r >= 19 && r <= 21 => 4,
                var r when r >= 22 && r <= 23 => 5,
                var r when r >= 24 && r <= 25 => 6,
                var r when r >= 26 && r <= 27 => 7,
                var r when r >= 28 && r <= 29 => 8,
                var r when r >= 30 && r <= 31 => 9,
                var r when r >= 32 && r <= 33 => 10,
                34 => 11,
                35 => 12,
                var r when r >= 36 && r <= 37 => 13,
                38 => 14,
                39 => 15,
                40 => 16,
                var r when r >= 41 && r <= 42 => 17,
                43 => 18,
                44 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetSimilaritiesDescriptor()
        {
            return new TestDescriptorPerAge((0, 33));
        }

        public short GetSimilaritiesStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 5 => 1,
                6 => 2,
                7 => 3,
                var r when r >= 8 && r <= 9 => 4,
                var r when r >= 10 && r <= 11 => 5,
                12 => 6,
                var r when r >= 13 && r <= 14 => 7,
                15 => 8,
                var r when r >= 16 && r <= 17 => 9,
                18 => 10,
                var r when r >= 19 && r <= 20 => 11,
                21 => 12,
                22 => 13,
                23 => 14,
                24 => 15,
                25 => 16,
                26 => 17,
                27 => 18,
                var r when r >= 28 && r <= 33 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetSymbolSearchDescriptor()
        {
            return new TestDescriptorPerAge((0, 45));
        }

        public short GetSymbolSearchStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 12 => 1,
                var r when r >= 13 && r <= 14 => 2,
                15 => 3,
                var r when r >= 16 && r <= 17 => 4,
                var r when r >= 18 && r <= 19 => 5,
                var r when r >= 20 && r <= 21 => 6,
                var r when r >= 22 && r <= 23 => 7,
                var r when r >= 24 && r <= 25 => 8,
                var r when r >= 26 && r <= 27 => 9,
                var r when r >= 28 && r <= 29 => 10,
                var r when r >= 30 && r <= 31 => 11,
                32 => 12,
                var r when r >= 33 && r <= 34 => 13,
                35 => 14,
                var r when r >= 36 && r <= 37 => 15,
                38 => 16,
                39 => 17,
                40 => 18,
                var r when r >= 41 && r <= 45 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetVocabularyDescriptor()
        {
            return new TestDescriptorPerAge((0, 60));
        }

        public short GetVocabularyStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 10 => 1,
                var r when r >= 11 && r <= 12 => 2,
                var r when r >= 13 && r <= 15 => 3,
                var r when r >= 16 && r <= 17 => 4,
                var r when r >= 18 && r <= 20 => 5,
                var r when r >= 21 && r <= 22 => 6,
                var r when r >= 23 && r <= 24 => 7,
                var r when r >= 25 && r <= 27 => 8,
                var r when r >= 28 && r <= 29 => 9,
                var r when r >= 30 && r <= 32 => 10,
                var r when r >= 33 && r <= 34 => 11,
                var r when r >= 35 && r <= 36 => 12,
                var r when r >= 37 && r <= 38 => 13,
                var r when r >= 39 && r <= 40 => 14,
                var r when r >= 41 && r <= 42 => 15,
                var r when r >= 43 && r <= 44 => 16,
                45 => 17,
                46 => 18,
                var r when r >= 47 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
