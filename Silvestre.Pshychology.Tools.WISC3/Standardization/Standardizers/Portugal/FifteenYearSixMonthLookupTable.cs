using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class FifteenYearSixMonthLookupTable : IStandardizerLookupTable
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
                12 => 6,
                13 => 7,
                14 => 8,
                var r when r >= 15 && r <= 16 => 9,
                17 => 10,
                18 => 11,
                var r when r >= 19 && r <= 20 => 12,
                21 => 13,
                22 => 14,
                23 => 15,
                24 => 16,
                25 => 17,
                26 => 18,
                var r when r >= 27 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 33 => 1,
                var r when r >= 34 && r <= 37 => 2,
                var r when r >= 38 && r <= 42 => 3,
                var r when r >= 43 && r <= 47 => 4,
                var r when r >= 48 && r <= 51 => 5,
                var r when r >= 52 && r <= 55 => 6,
                var r when r >= 56 && r <= 57 => 7,
                var r when r >= 58 && r <= 62 => 8,
                var r when r >= 63 && r <= 66 => 9,
                var r when r >= 67 && r <= 69 => 10,
                var r when r >= 70 && r <= 72 => 11,
                var r when r >= 73 && r <= 77 => 12,
                var r when r >= 78 && r <= 80 => 13,
                var r when r >= 81 && r <= 83 => 14,
                var r when r >= 84 && r <= 86 => 15,
                var r when r >= 87 && r <= 88 => 16,
                var r when r >= 89 && r <= 90 => 17,
                var r when r >= 91 && r <= 93 => 18,
                var r when r >= 94 && r <= 119 => 19,
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
                var r when r >= 0 && r <= 10 => 1,
                11 => 2,
                12 => 3,
                13 => 4,
                var r when r >= 14 && r <= 15 => 5,
                var r when r >= 16 && r <= 17 => 6,
                18 => 7,
                19 => 8,
                var r when r >= 20 && r <= 21 => 9,
                var r when r >= 22 && r <= 23 => 10,
                24 => 11,
                25 => 12,
                var r when r >= 26 && r <= 27 => 13,
                28 => 14,
                29 => 15,
                var r when r >= 30 && r <= 31 => 16,
                32 => 17,
                33 => 18,
                var r when r >= 34 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 21 => 1,
                var r when r >= 22 && r <= 26 => 2,
                var r when r >= 27 && r <= 31 => 3,
                var r when r >= 32 && r <= 36 => 4,
                var r when r >= 37 && r <= 39 => 5,
                var r when r >= 40 && r <= 42 => 6,
                var r when r >= 43 && r <= 46 => 7,
                var r when r >= 47 && r <= 50 => 8,
                var r when r >= 51 && r <= 53 => 9,
                var r when r >= 54 && r <= 56 => 10,
                var r when r >= 57 && r <= 58 => 11,
                var r when r >= 59 && r <= 60 => 12,
                var r when r >= 61 && r <= 62 => 13,
                var r when r >= 63 && r <= 64 => 14,
                65 => 15,
                66 => 16,
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
                9 => 4,
                10 => 5,
                11 => 6,
                12 => 7,
                13 => 8,
                14 => 9,
                15 => 10,
                16 => 11,
                var r when r >= 17 && r <= 18 => 12,
                19 => 13,
                var r when r >= 20 && r <= 21 => 14,
                22 => 15,
                23 => 16,
                24 => 17,
                25 => 18,
                var r when r >= 26 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 14 => 1,
                15 => 2,
                16 => 3,
                17 => 4,
                18 => 5,
                19 => 6,
                20 => 7,
                21 => 8,
                22 => 9,
                23 => 10,
                24 => 11,
                25 => 13,
                26 => 14,
                27 => 15,
                28 => 16,
                29 => 17,
                30 => 18,
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
                var r when r >= 0 && r <= 11 => 1,
                var r when r >= 12 && r <= 13 => 2,
                var r when r >= 14 && r <= 16 => 3,
                var r when r >= 17 && r <= 20 => 4,
                var r when r >= 21 && r <= 23 => 5,
                var r when r >= 24 && r <= 25 => 6,
                var r when r >= 26 && r <= 29 => 7,
                var r when r >= 30 && r <= 32 => 8,
                var r when r >= 33 && r <= 35 => 9,
                var r when r >= 36 && r <= 38 => 10,
                var r when r >= 39 && r <= 41 => 11,
                var r when r >= 42 && r <= 44 => 12,
                var r when r >= 45 && r <= 47 => 13,
                var r when r >= 48 && r <= 49 => 14,
                var r when r >= 50 && r <= 52 => 15,
                var r when r >= 53 && r <= 54 => 16,
                55 => 17,
                var r when r >= 56 && r <= 57 => 18,
                var r when r >= 58 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 10 => 1,
                11 => 2,
                var r when r >= 12 && r <= 13 => 3,
                14 => 4,
                var r when r >= 15 && r <= 16 => 5,
                17 => 6,
                18 => 7,
                19 => 8,
                var r when r >= 20 && r <= 21 => 9,
                22 => 10,
                23 => 11,
                24 => 12,
                25 => 13,
                26 => 14,
                27 => 15,
                28 => 16,
                29 => 18,
                30 => 19,
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
                var r when r >= 0 && r <= 12 => 1,
                var r when r >= 13 && r <= 14 => 2,
                15 => 3,
                16 => 4,
                17 => 5,
                18 => 6,
                19 => 7,
                var r when r >= 20 && r <= 21 => 8,
                22 => 9,
                var r when r >= 23 && r <= 24 => 10,
                25 => 11,
                26 => 13,
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
                var r when r >= 0 && r <= 17 => 1,
                var r when r >= 18 && r <= 19 => 2,
                var r when r >= 20 && r <= 21 => 3,
                22 => 4,
                var r when r >= 23 && r <= 25 => 5,
                var r when r >= 26 && r <= 27 => 6,
                28 => 7,
                var r when r >= 29 && r <= 30 => 8,
                var r when r >= 31 && r <= 32 => 9,
                33 => 10,
                var r when r >= 34 && r <= 35 => 11,
                36 => 12,
                37 => 13,
                var r when r >= 38 && r <= 39 => 14,
                40 => 15,
                41 => 16,
                42 => 17,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 10 => 2,
                11 => 3,
                12 => 4,
                var r when r >= 13 && r <= 14 => 5,
                15 => 6,
                var r when r >= 16 && r <= 17 => 7,
                18 => 8,
                var r when r >= 19 && r <= 20 => 9,
                21 => 10,
                22 => 11,
                23 => 12,
                var r when r >= 24 && r <= 25 => 13,
                26 => 14,
                27 => 15,
                28 => 16,
                29 => 17,
                30 => 18,
                var r when r >= 31 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 16 => 1,
                var r when r >= 17 && r <= 18 => 2,
                var r when r >= 19 && r <= 20 => 3,
                21 => 4,
                var r when r >= 22 && r <= 23 => 5,
                24 => 6,
                25 => 7,
                var r when r >= 26 && r <= 27 => 8,
                var r when r >= 28 && r <= 29 => 9,
                var r when r >= 30 && r <= 31 => 10,
                32 => 11,
                var r when r >= 33 && r <= 34 => 12,
                var r when r >= 35 && r <= 36 => 13,
                var r when r >= 37 && r <= 38 => 14,
                39 => 15,
                var r when r >= 40 && r <= 41 => 16,
                42 => 17,
                43 => 18,
                var r when r >= 44 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 14 => 1,
                var r when r >= 15 && r <= 16 => 2,
                var r when r >= 17 && r <= 18 => 3,
                var r when r >= 19 && r <= 21 => 4,
                var r when r >= 22 && r <= 24 => 5,
                var r when r >= 25 && r <= 27 => 6,
                var r when r >= 28 && r <= 30 => 7,
                var r when r >= 31 && r <= 33 => 8,
                var r when r >= 34 && r <= 35 => 9,
                var r when r >= 36 && r <= 38 => 10,
                var r when r >= 39 && r <= 40 => 11,
                var r when r >= 41 && r <= 43 => 12,
                var r when r >= 44 && r <= 45 => 13,
                var r when r >= 46 && r <= 47 => 14,
                var r when r >= 48 && r <= 49 => 15,
                var r when r >= 50 && r <= 51 => 16,
                var r when r >= 52 && r <= 53 => 17,
                54 => 18,
                var r when r >= 55 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
