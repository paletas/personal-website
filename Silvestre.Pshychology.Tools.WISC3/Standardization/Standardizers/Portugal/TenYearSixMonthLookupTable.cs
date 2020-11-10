using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class TenYearSixMonthLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 5 => 1,
                6 => 2,
                7 => 3,
                8 => 4,
                9 => 6,
                10 => 7,
                11 => 8,
                12 => 9,
                13 => 10,
                14 => 11,
                15 => 12,
                16 => 13,
                17 => 14,
                18 => 15,
                19 => 16,
                20 => 17,
                var r when r >= 21 && r <= 22 => 18,
                var r when r >= 23 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 17 => 1,
                var r when r >= 18 && r <= 22 => 2,
                var r when r >= 23 && r <= 25 => 3,
                var r when r >= 26 && r <= 28 => 4,
                var r when r >= 29 && r <= 31 => 5,
                var r when r >= 32 && r <= 34 => 6,
                var r when r >= 35 && r <= 37 => 7,
                var r when r >= 38 && r <= 41 => 8,
                var r when r >= 42 && r <= 44 => 9,
                var r when r >= 45 && r <= 47 => 10,
                var r when r >= 48 && r <= 50 => 11,
                var r when r >= 51 && r <= 53 => 12,
                var r when r >= 54 && r <= 56 => 13,
                var r when r >= 57 && r <= 58 => 14,
                var r when r >= 59 && r <= 60 => 15,
                var r when r >= 61 && r <= 62 => 16,
                var r when r >= 63 && r <= 64 => 17,
                var r when r >= 65 && r <= 66 => 18,
                var r when r >= 67 && r <= 119 => 19,
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
                var r when r >= 0 && r <= 2 => 1,
                3 => 2,
                4 => 3,
                5 => 4,
                var r when r >= 6 && r <= 8 => 5,
                9 => 6,
                10 => 7,
                11 => 8,
                12 => 9,
                13 => 10,
                14 => 11,
                var r when r >= 15 && r <= 16 => 12,
                17 => 13,
                var r when r >= 18 && r <= 19 => 14,
                var r when r >= 20 && r <= 21 => 15,
                22 => 16,
                23 => 17,
                24 => 18,
                var r when r >= 25 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 6 => 1,
                var r when r >= 7 && r <= 10 => 2,
                var r when r >= 11 && r <= 13 => 3,
                var r when r >= 14 && r <= 17 => 4,
                var r when r >= 18 && r <= 19 => 5,
                var r when r >= 20 && r <= 24 => 6,
                var r when r >= 25 && r <= 28 => 7,
                var r when r >= 29 && r <= 33 => 8,
                var r when r >= 34 && r <= 36 => 9,
                var r when r >= 37 && r <= 39 => 10,
                var r when r >= 40 && r <= 43 => 11,
                var r when r >= 44 && r <= 46 => 12,
                var r when r >= 47 && r <= 50 => 13,
                var r when r >= 51 && r <= 52 => 14,
                var r when r >= 53 && r <= 56 => 15,
                var r when r >= 57 && r <= 59 => 16,
                60 => 17,
                var r when r >= 61 && r <= 62 => 18,
                var r when r >= 63 && r <= 69 => 19,
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
                var r when r >= 0 && r <= 4 => 1,
                5 => 2,
                6 => 3,
                7 => 4,
                8 => 5,
                9 => 6,
                10 => 8,
                11 => 9,
                12 => 10,
                13 => 11,
                14 => 12,
                15 => 13,
                16 => 14,
                17 => 15,
                18 => 16,
                19 => 17,
                20 => 18,
                var r when r >= 21 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 9 => 1,
                10 => 2,
                11 => 3,
                12 => 4,
                13 => 5,
                14 => 6,
                15 => 7,
                var r when r >= 16 && r <= 17 => 8,
                var r when r >= 18 && r <= 19 => 9,
                20 => 10,
                21 => 12,
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

        TestDescriptorPerAge IStandardizerLookupTable.GetImageDispositionDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetImageDispositionStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 5 => 1,
                var r when r >= 6 && r <= 8 => 2,
                var r when r >= 9 && r <= 11 => 3,
                12 => 4,
                var r when r >= 13 && r <= 14 => 5,
                var r when r >= 15 && r <= 17 => 6,
                var r when r >= 18 && r <= 19 => 7,
                var r when r >= 20 && r <= 22 => 8,
                var r when r >= 23 && r <= 25 => 9,
                var r when r >= 26 && r <= 27 => 10,
                var r when r >= 28 && r <= 30 => 11,
                var r when r >= 31 && r <= 33 => 12,
                var r when r >= 34 && r <= 37 => 13,
                var r when r >= 38 && r <= 39 => 14,
                var r when r >= 40 && r <= 42 => 15,
                43 => 16,
                44 => 17,
                var r when r >= 45 && r <= 46 => 18,
                var r when r >= 47 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 5 => 1,
                6 => 2,
                7 => 3,
                8 => 4,
                9 => 5,
                10 => 6,
                11 => 7,
                12 => 8,
                13 => 9,
                var r when r >= 14 && r <= 15 => 10,
                16 => 11,
                17 => 12,
                18 => 13,
                19 => 14,
                20 => 15,
                21 => 16,
                22 => 17,
                23 => 18,
                var r when r >= 24 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 6 => 1,
                7 => 2,
                8 => 3,
                var r when r >= 9 && r <= 10 => 4,
                var r when r >= 11 && r <= 12 => 5,
                var r when r >= 13 && r <= 14 => 6,
                15 => 7,
                var r when r >= 16 && r <= 17 => 8,
                var r when r >= 18 && r <= 19 => 9,
                20 => 10,
                var r when r >= 21 && r <= 22 => 11,
                23 => 12,
                24 => 13,
                25 => 14,
                26 => 15,
                27 => 17,
                28 => 18,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 10 => 2,
                var r when r >= 11 && r <= 13 => 3,
                var r when r >= 14 && r <= 16 => 4,
                var r when r >= 17 && r <= 18 => 5,
                var r when r >= 19 && r <= 21 => 6,
                22 => 7,
                var r when r >= 23 && r <= 24 => 8,
                var r when r >= 25 && r <= 27 => 9,
                var r when r >= 28 && r <= 29 => 10,
                30 => 11,
                var r when r >= 31 && r <= 32 => 12,
                33 => 13,
                var r when r >= 34 && r <= 35 => 14,
                var r when r >= 36 && r <= 37 => 15,
                38 => 16,
                39 => 17,
                40 => 18,
                var r when r >= 41 && r <= 44 => 19,
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
                0 => 2,
                1 => 3,
                2 => 4,
                var r when r >= 3 && r <= 4 => 5,
                5 => 6,
                var r when r >= 6 && r <= 7 => 7,
                8 => 8,
                var r when r >= 9 && r <= 10 => 9,
                var r when r >= 11 && r <= 12 => 10,
                var r when r >= 13 && r <= 14 => 11,
                var r when r >= 15 && r <= 16 => 12,
                17 => 13,
                var r when r >= 18 && r <= 19 => 14,
                20 => 15,
                21 => 16,
                22 => 17,
                23 => 18,
                var r when r >= 24 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 7 => 1,
                var r when r >= 8 && r <= 9 => 2,
                10 => 3,
                var r when r >= 11 && r <= 12 => 4,
                var r when r >= 13 && r <= 14 => 5,
                var r when r >= 15 && r <= 16 => 6,
                17 => 7,
                var r when r >= 18 && r <= 19 => 8,
                20 => 9,
                var r when r >= 21 && r <= 23 => 10,
                24 => 11,
                25 => 12,
                var r when r >= 26 && r <= 27 => 13,
                28 => 14,
                var r when r >= 29 && r <= 30 => 15,
                31 => 16,
                32 => 17,
                33 => 18,
                var r when r >= 34 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 5 => 1,
                var r when r >= 6 && r <= 8 => 2,
                var r when r >= 9 && r <= 10 => 3,
                var r when r >= 11 && r <= 12 => 4,
                13 => 5,
                14 => 6,
                var r when r >= 15 && r <= 16 => 7,
                var r when r >= 17 && r <= 18 => 8,
                19 => 9,
                var r when r >= 20 && r <= 21 => 10,
                var r when r >= 22 && r <= 23 => 11,
                var r when r >= 24 && r <= 25 => 12,
                var r when r >= 26 && r <= 27 => 13,
                var r when r >= 28 && r <= 30 => 14,
                var r when r >= 31 && r <= 32 => 15,
                var r when r >= 33 && r <= 34 => 16,
                var r when r >= 35 && r <= 36 => 17,
                37 => 18,
                var r when r >= 38 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
