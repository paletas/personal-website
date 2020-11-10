using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class NineYearSixMonthLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 4 => 1,
                5 => 2,
                6 => 3,
                7 => 4,
                8 => 5,
                9 => 6,
                10 => 7,
                11 => 8,
                12 => 9,
                13 => 10,
                14 => 11,
                15 => 13,
                16 => 14,
                17 => 15,
                18 => 16,
                19 => 18,
                var r when r >= 20 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 14 => 1,
                var r when r >= 15 && r <= 18 => 2,
                var r when r >= 19 && r <= 22 => 3,
                var r when r >= 23 && r <= 26 => 4,
                var r when r >= 27 && r <= 28 => 5,
                var r when r >= 29 && r <= 30 => 6,
                var r when r >= 31 && r <= 33 => 7,
                var r when r >= 34 && r <= 37 => 8,
                var r when r >= 38 && r <= 39 => 9,
                var r when r >= 40 && r <= 43 => 10,
                var r when r >= 44 && r <= 46 => 11,
                var r when r >= 47 && r <= 49 => 12,
                var r when r >= 50 && r <= 52 => 13,
                var r when r >= 53 && r <= 55 => 14,
                var r when r >= 56 && r <= 57 => 15,
                58 => 16,
                59 => 17,
                60 => 18,
                var r when r >= 61 && r <= 119 => 19,
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
                var r when r >= 0 && r <= 1 => 1,
                2 => 2,
                3 => 3,
                4 => 4,
                var r when r >= 5 && r <= 6 => 5,
                7 => 6,
                8 => 7,
                9 => 8,
                10 => 9,
                11 => 10,
                12 => 11,
                13 => 12,
                var r when r >= 14 && r <= 15 => 13,
                16 => 14,
                17 => 15,
                var r when r >= 18 && r <= 19 => 16,
                20 => 17,
                21 => 18,
                var r when r >= 22 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 3 => 1,
                var r when r >= 4 && r <= 6 => 2,
                var r when r >= 7 && r <= 11 => 3,
                var r when r >= 12 && r <= 16 => 4,
                var r when r >= 17 && r <= 19 => 5,
                var r when r >= 20 && r <= 22 => 6,
                var r when r >= 23 && r <= 25 => 7,
                var r when r >= 26 && r <= 29 => 8,
                var r when r >= 30 && r <= 32 => 9,
                var r when r >= 33 && r <= 36 => 10,
                var r when r >= 37 && r <= 39 => 11,
                var r when r >= 40 && r <= 42 => 12,
                var r when r >= 43 && r <= 45 => 13,
                var r when r >= 46 && r <= 50 => 14,
                var r when r >= 51 && r <= 53 => 15,
                var r when r >= 54 && r <= 56 => 16,
                var r when r >= 57 && r <= 58 => 17,
                var r when r >= 59 && r <= 60 => 18,
                var r when r >= 61 && r <= 69 => 19,
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
                9 => 7,
                10 => 8,
                11 => 9,
                12 => 10,
                13 => 11,
                14 => 13,
                15 => 14,
                16 => 15,
                17 => 16,
                18 => 17,
                var r when r >= 19 && r <= 20 => 18,
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
                var r when r >= 0 && r <= 7 => 1,
                8 => 2,
                9 => 3,
                10 => 4,
                var r when r >= 11 && r <= 12 => 5,
                13 => 6,
                14 => 7,
                15 => 8,
                16 => 9,
                17 => 10,
                18 => 11,
                19 => 12,
                var r when r >= 20 && r <= 21 => 13,
                22 => 14,
                23 => 15,
                24 => 16,
                25 => 17,
                var r when r >= 26 && r <= 27 => 18,
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
                var r when r >= 0 && r <= 2 => 1,
                3 => 2,
                var r when r >= 4 && r <= 5 => 3,
                var r when r >= 6 && r <= 9 => 4,
                var r when r >= 10 && r <= 11 => 5,
                var r when r >= 12 && r <= 13 => 6,
                var r when r >= 14 && r <= 16 => 7,
                var r when r >= 17 && r <= 19 => 8,
                var r when r >= 20 && r <= 21 => 9,
                var r when r >= 22 && r <= 24 => 10,
                var r when r >= 25 && r <= 27 => 11,
                var r when r >= 28 && r <= 30 => 12,
                var r when r >= 31 && r <= 32 => 13,
                var r when r >= 33 && r <= 35 => 14,
                var r when r >= 36 && r <= 38 => 15,
                39 => 16,
                var r when r >= 40 && r <= 41 => 17,
                42 => 18,
                var r when r >= 43 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 4 => 1,
                5 => 2,
                6 => 3,
                7 => 4,
                8 => 5,
                9 => 6,
                10 => 7,
                11 => 8,
                12 => 9,
                13 => 10,
                var r when r >= 14 && r <= 15 => 11,
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
                9 => 4,
                10 => 5,
                var r when r >= 11 && r <= 12 => 6,
                var r when r >= 13 && r <= 14 => 7,
                var r when r >= 15 && r <= 16 => 8,
                17 => 9,
                var r when r >= 18 && r <= 19 => 10,
                var r when r >= 20 && r <= 21 => 11,
                22 => 12,
                23 => 13,
                24 => 14,
                25 => 15,
                26 => 16,
                27 => 18,
                28 => 19,
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
                var r when r >= 0 && r <= 6 => 1,
                var r when r >= 7 && r <= 9 => 2,
                var r when r >= 10 && r <= 11 => 3,
                var r when r >= 12 && r <= 13 => 4,
                var r when r >= 14 && r <= 15 => 5,
                var r when r >= 16 && r <= 18 => 6,
                var r when r >= 19 && r <= 20 => 7,
                var r when r >= 21 && r <= 22 => 8,
                var r when r >= 23 && r <= 25 => 9,
                var r when r >= 26 && r <= 28 => 10,
                29 => 11,
                30 => 12,
                var r when r >= 31 && r <= 32 => 13,
                33 => 14,
                var r when r >= 34 && r <= 35 => 15,
                36 => 16,
                37 => 17,
                38 => 18,
                var r when r >= 39 && r <= 44 => 19,
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
                0 => 3,
                1 => 4,
                var r when r >= 2 && r <= 3 => 5,
                4 => 6,
                5 => 7,
                6 => 8,
                7 => 9,
                var r when r >= 8 && r <= 9 => 10,
                var r when r >= 10 && r <= 11 => 11,
                var r when r >= 12 && r <= 13 => 12,
                var r when r >= 14 && r <= 15 => 13,
                var r when r >= 16 && r <= 17 => 14,
                18 => 15,
                19 => 16,
                20 => 17,
                21 => 18,
                var r when r >= 22 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 5 => 1,
                var r when r >= 6 && r <= 7 => 2,
                8 => 3,
                9 => 4,
                var r when r >= 10 && r <= 11 => 5,
                var r when r >= 12 && r <= 13 => 6,
                var r when r >= 14 && r <= 15 => 7,
                var r when r >= 16 && r <= 17 => 8,
                18 => 9,
                19 => 10,
                var r when r >= 20 && r <= 21 => 11,
                var r when r >= 22 && r <= 23 => 12,
                24 => 13,
                var r when r >= 25 && r <= 26 => 14,
                var r when r >= 27 && r <= 28 => 15,
                29 => 16,
                30 => 17,
                31 => 18,
                var r when r >= 32 && r <= 45 => 19,
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
                6 => 2,
                var r when r >= 7 && r <= 8 => 3,
                9 => 4,
                var r when r >= 10 && r <= 11 => 5,
                var r when r >= 12 && r <= 13 => 6,
                14 => 7,
                15 => 8,
                var r when r >= 16 && r <= 17 => 9,
                var r when r >= 18 && r <= 19 => 10,
                20 => 11,
                var r when r >= 21 && r <= 22 => 12,
                var r when r >= 23 && r <= 24 => 13,
                25 => 14,
                var r when r >= 26 && r <= 27 => 15,
                var r when r >= 28 && r <= 29 => 16,
                var r when r >= 30 && r <= 32 => 17,
                var r when r >= 33 && r <= 34 => 18,
                var r when r >= 35 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
