using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class TwelveYearSixMonthLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
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
                17 => 13,
                18 => 14,
                var r when r >= 19 && r <= 20 => 15,
                21 => 16,
                22 => 17,
                23 => 18,
                var r when r >= 24 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 24 => 1,
                var r when r >= 25 && r <= 28 => 2,
                var r when r >= 29 && r <= 31 => 3,
                var r when r >= 32 && r <= 35 => 4,
                var r when r >= 36 && r <= 38 => 5,
                var r when r >= 39 && r <= 41 => 6,
                var r when r >= 42 && r <= 45 => 7,
                var r when r >= 46 && r <= 49 => 8,
                var r when r >= 50 && r <= 53 => 9,
                var r when r >= 54 && r <= 56 => 10,
                var r when r >= 57 && r <= 59 => 11,
                var r when r >= 60 && r <= 63 => 12,
                var r when r >= 64 && r <= 66 => 13,
                var r when r >= 67 && r <= 70 => 14,
                var r when r >= 71 && r <= 74 => 15,
                var r when r >= 75 && r <= 78 => 16,
                var r when r >= 79 && r <= 80 => 17,
                var r when r >= 81 && r <= 82 => 18,
                var r when r >= 83 && r <= 119 => 19,
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
                var r when r >= 0 && r <= 5 => 1,
                var r when r >= 6 && r <= 7 => 2,
                8 => 3,
                9 => 4,
                10 => 5,
                11 => 6,
                12 => 7,
                var r when r >= 13 && r <= 14 => 8,
                var r when r >= 15 && r <= 16 => 9,
                17 => 10,
                18 => 11,
                19 => 12,
                var r when r >= 20 && r <= 21 => 13,
                22 => 14,
                var r when r >= 23 && r <= 24 => 15,
                var r when r >= 25 && r <= 26 => 16,
                27 => 17,
                28 => 18,
                var r when r >= 29 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 12 => 1,
                var r when r >= 13 && r <= 17 => 2,
                var r when r >= 18 && r <= 22 => 3,
                var r when r >= 23 && r <= 26 => 4,
                var r when r >= 27 && r <= 30 => 5,
                var r when r >= 31 && r <= 34 => 6,
                var r when r >= 35 && r <= 38 => 7,
                var r when r >= 39 && r <= 41 => 8,
                var r when r >= 42 && r <= 45 => 9,
                var r when r >= 46 && r <= 48 => 10,
                var r when r >= 49 && r <= 52 => 11,
                var r when r >= 53 && r <= 55 => 12,
                var r when r >= 56 && r <= 58 => 13,
                var r when r >= 59 && r <= 60 => 14,
                var r when r >= 61 && r <= 63 => 15,
                64 => 16,
                65 => 17,
                66 => 18,
                var r when r >= 67 && r <= 69 => 19,
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
                var r when r >= 0 && r <= 5 => 1,
                6 => 2,
                7 => 3,
                8 => 4,
                9 => 5,
                10 => 7,
                11 => 8,
                12 => 9,
                var r when r >= 13 && r <= 14 => 10,
                15 => 11,
                16 => 12,
                17 => 13,
                18 => 14,
                19 => 15,
                20 => 16,
                21 => 17,
                22 => 18,
                var r when r >= 23 && r <= 30 => 19,
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
                18 => 7,
                var r when r >= 19 && r <= 20 => 8,
                21 => 9,
                22 => 11,
                23 => 12,
                24 => 14,
                25 => 15,
                26 => 16,
                27 => 17,
                28 => 18,
                var r when r >= 29 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 7 => 1,
                var r when r >= 8 && r <= 9 => 2,
                var r when r >= 10 && r <= 11 => 3,
                var r when r >= 12 && r <= 14 => 4,
                var r when r >= 15 && r <= 19 => 5,
                var r when r >= 20 && r <= 22 => 6,
                var r when r >= 23 && r <= 25 => 7,
                var r when r >= 26 && r <= 27 => 8,
                var r when r >= 28 && r <= 30 => 9,
                var r when r >= 31 && r <= 34 => 10,
                var r when r >= 35 && r <= 37 => 11,
                var r when r >= 38 && r <= 41 => 12,
                var r when r >= 42 && r <= 43 => 13,
                var r when r >= 44 && r <= 47 => 14,
                var r when r >= 48 && r <= 50 => 15,
                var r when r >= 51 && r <= 52 => 16,
                53 => 17,
                var r when r >= 54 && r <= 55 => 18,
                var r when r >= 56 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 8 => 1,
                9 => 2,
                10 => 3,
                11 => 5,
                12 => 6,
                var r when r >= 13 && r <= 14 => 7,
                15 => 8,
                var r when r >= 16 && r <= 17 => 9,
                18 => 10,
                19 => 11,
                var r when r >= 20 && r <= 21 => 12,
                22 => 13,
                23 => 14,
                24 => 15,
                25 => 16,
                26 => 17,
                27 => 18,
                var r when r >= 28 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 10 => 2,
                var r when r >= 11 && r <= 12 => 3,
                13 => 4,
                14 => 5,
                15 => 6,
                var r when r >= 16 && r <= 17 => 7,
                18 => 8,
                var r when r >= 19 && r <= 20 => 9,
                var r when r >= 21 && r <= 22 => 10,
                23 => 11,
                24 => 12,
                25 => 13,
                26 => 14,
                27 => 15,
                28 => 17,
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
                var r when r >= 0 && r <= 11 => 1,
                var r when r >= 12 && r <= 14 => 2,
                var r when r >= 15 && r <= 17 => 3,
                var r when r >= 18 && r <= 19 => 4,
                var r when r >= 20 && r <= 22 => 5,
                var r when r >= 23 && r <= 24 => 6,
                var r when r >= 25 && r <= 26 => 7,
                var r when r >= 27 && r <= 28 => 8,
                var r when r >= 29 && r <= 30 => 9,
                var r when r >= 31 && r <= 32 => 10,
                33 => 11,
                var r when r >= 34 && r <= 35 => 12,
                36 => 13,
                37 => 14,
                var r when r >= 38 && r <= 39 => 15,
                40 => 16,
                41 => 17,
                42 => 18,
                var r when r >= 43 && r <= 44 => 19,
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
                var r when r >= 0 && r <= 4 => 1,
                5 => 2,
                6 => 3,
                7 => 4,
                var r when r >= 8 && r <= 9 => 5,
                10 => 6,
                var r when r >= 11 && r <= 12 => 7,
                var r when r >= 13 && r <= 14 => 8,
                15 => 9,
                16 => 10,
                var r when r >= 17 && r <= 18 => 11,
                19 => 12,
                var r when r >= 20 && r <= 21 => 13,
                22 => 14,
                23 => 15,
                24 => 16,
                25 => 18,
                var r when r >= 26 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 9 => 1,
                var r when r >= 10 && r <= 11 => 2,
                var r when r >= 12 && r <= 13 => 3,
                var r when r >= 14 && r <= 15 => 4,
                var r when r >= 16 && r <= 17 => 5,
                var r when r >= 18 && r <= 19 => 6,
                var r when r >= 20 && r <= 21 => 7,
                var r when r >= 22 && r <= 23 => 8,
                24 => 9,
                var r when r >= 25 && r <= 26 => 10,
                var r when r >= 27 && r <= 28 => 11,
                var r when r >= 29 && r <= 30 => 12,
                var r when r >= 31 && r <= 32 => 13,
                33 => 14,
                var r when r >= 34 && r <= 35 => 15,
                36 => 16,
                var r when r >= 37 && r <= 38 => 17,
                39 => 18,
                var r when r >= 40 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 9 => 1,
                var r when r >= 10 && r <= 11 => 2,
                var r when r >= 12 && r <= 13 => 3,
                14 => 4,
                15 => 5,
                var r when r >= 16 && r <= 17 => 6,
                var r when r >= 18 && r <= 20 => 7,
                var r when r >= 21 && r <= 23 => 8,
                var r when r >= 24 && r <= 25 => 9,
                var r when r >= 26 && r <= 28 => 10,
                var r when r >= 29 && r <= 30 => 11,
                var r when r >= 31 && r <= 32 => 12,
                var r when r >= 33 && r <= 35 => 13,
                var r when r >= 36 && r <= 38 => 14,
                var r when r >= 39 && r <= 41 => 15,
                var r when r >= 42 && r <= 43 => 16,
                44 => 17,
                45 => 18,
                var r when r >= 46 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
