using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class EightYearSixMonthLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 3 => 1,
                var r when r >= 4 && r <= 5 => 2,
                6 => 3,
                7 => 4,
                8 => 6,
                9 => 7,
                10 => 8,
                11 => 9,
                12 => 10,
                13 => 12,
                14 => 13,
                15 => 14,
                16 => 15,
                17 => 16,
                18 => 17,
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
                var r when r >= 0 && r <= 11 => 1,
                var r when r >= 12 && r <= 16 => 2,
                var r when r >= 17 && r <= 21 => 3,
                var r when r >= 22 && r <= 23 => 4,
                var r when r >= 24 && r <= 26 => 5,
                var r when r >= 27 && r <= 28 => 6,
                var r when r >= 29 && r <= 30 => 7,
                var r when r >= 31 && r <= 32 => 8,
                var r when r >= 33 && r <= 35 => 9,
                var r when r >= 36 && r <= 37 => 10,
                var r when r >= 38 && r <= 40 => 11,
                var r when r >= 41 && r <= 44 => 12,
                var r when r >= 45 && r <= 46 => 13,
                var r when r >= 47 && r <= 49 => 14,
                var r when r >= 50 && r <= 51 => 15,
                var r when r >= 52 && r <= 55 => 16,
                var r when r >= 56 && r <= 57 => 17,
                var r when r >= 58 && r <= 59 => 18,
                var r when r >= 60 && r <= 119 => 19,
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
                0 => 1,
                1 => 2,
                2 => 3,
                3 => 4,
                4 => 5,
                5 => 6,
                6 => 7,
                7 => 8,
                var r when r >= 8 && r <= 9 => 9,
                10 => 10,
                11 => 11,
                12 => 12,
                13 => 13,
                14 => 14,
                15 => 15,
                16 => 17,
                17 => 18,
                var r when r >= 18 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 1 => 1,
                var r when r >= 2 && r <= 3 => 2,
                var r when r >= 4 && r <= 5 => 3,
                var r when r >= 6 && r <= 8 => 4,
                var r when r >= 9 && r <= 11 => 5,
                var r when r >= 12 && r <= 15 => 6,
                var r when r >= 16 && r <= 19 => 7,
                var r when r >= 20 && r <= 22 => 8,
                var r when r >= 23 && r <= 26 => 9,
                var r when r >= 27 && r <= 31 => 10,
                var r when r >= 32 && r <= 35 => 11,
                var r when r >= 36 && r <= 39 => 12,
                var r when r >= 40 && r <= 43 => 13,
                var r when r >= 44 && r <= 47 => 14,
                var r when r >= 48 && r <= 52 => 15,
                var r when r >= 53 && r <= 54 => 16,
                var r when r >= 55 && r <= 57 => 17,
                var r when r >= 58 && r <= 59 => 18,
                var r when r >= 60 && r <= 69 => 19,
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
                7 => 5,
                8 => 6,
                9 => 7,
                10 => 9,
                11 => 10,
                12 => 11,
                13 => 12,
                14 => 13,
                15 => 14,
                16 => 15,
                17 => 16,
                18 => 17,
                19 => 18,
                var r when r >= 20 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 6 => 1,
                7 => 2,
                8 => 3,
                9 => 4,
                10 => 5,
                11 => 6,
                12 => 7,
                13 => 8,
                14 => 9,
                var r when r >= 15 && r <= 16 => 10,
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

        TestDescriptorPerAge IStandardizerLookupTable.GetImageDispositionDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetImageDispositionStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 1 => 1,
                2 => 2,
                var r when r >= 3 && r <= 4 => 3,
                var r when r >= 5 && r <= 6 => 4,
                var r when r >= 7 && r <= 9 => 5,
                10 => 6,
                var r when r >= 11 && r <= 13 => 7,
                var r when r >= 14 && r <= 16 => 8,
                var r when r >= 17 && r <= 18 => 9,
                var r when r >= 19 && r <= 20 => 10,
                var r when r >= 21 && r <= 23 => 11,
                var r when r >= 24 && r <= 26 => 12,
                var r when r >= 27 && r <= 29 => 13,
                var r when r >= 30 && r <= 32 => 14,
                33 => 15,
                var r when r >= 34 && r <= 35 => 16,
                36 => 17,
                var r when r >= 37 && r <= 39 => 18,
                var r when r >= 40 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 2 => 1,
                var r when r >= 3 && r <= 4 => 2,
                5 => 3,
                6 => 4,
                7 => 5,
                8 => 6,
                9 => 8,
                10 => 9,
                11 => 10,
                12 => 11,
                var r when r >= 13 && r <= 14 => 12,
                15 => 13,
                16 => 14,
                17 => 15,
                var r when r >= 18 && r <= 19 => 16,
                20 => 17,
                var r when r >= 21 && r <= 22 => 18,
                var r when r >= 23 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 5 => 1,
                6 => 2,
                7 => 3,
                8 => 4,
                9 => 5,
                10 => 6,
                var r when r >= 11 && r <= 12 => 7,
                var r when r >= 13 && r <= 14 => 8,
                15 => 9,
                var r when r >= 16 && r <= 17 => 10,
                var r when r >= 18 && r <= 19 => 11,
                var r when r >= 20 && r <= 21 => 12,
                var r when r >= 22 && r <= 23 => 13,
                24 => 14,
                25 => 15,
                26 => 17,
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
                var r when r >= 0 && r <= 3 => 1,
                var r when r >= 4 && r <= 5 => 2,
                6 => 3,
                var r when r >= 7 && r <= 8 => 4,
                var r when r >= 9 && r <= 11 => 5,
                var r when r >= 12 && r <= 13 => 6,
                var r when r >= 14 && r <= 16 => 7,
                var r when r >= 17 && r <= 20 => 8,
                var r when r >= 21 && r <= 22 => 9,
                var r when r >= 23 && r <= 24 => 10,
                var r when r >= 25 && r <= 27 => 11,
                var r when r >= 28 && r <= 29 => 12,
                30 => 13,
                31 => 14,
                32 => 15,
                33 => 16,
                var r when r >= 34 && r <= 35 => 17,
                var r when r >= 36 && r <= 37 => 18,
                var r when r >= 38 && r <= 44 => 19,
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
                2 => 5,
                3 => 6,
                4 => 7,
                5 => 8,
                6 => 9,
                7 => 10,
                8 => 11,
                var r when r >= 9 && r <= 10 => 12,
                var r when r >= 11 && r <= 12 => 13,
                13 => 14,
                var r when r >= 14 && r <= 16 => 15,
                17 => 16,
                18 => 17,
                19 => 18,
                var r when r >= 20 && r <= 33 => 19,
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
                0 => 1,
                var r when r >= 1 && r <= 2 => 2,
                3 => 3,
                var r when r >= 4 && r <= 5 => 4,
                var r when r >= 6 && r <= 8 => 5,
                var r when r >= 9 && r <= 10 => 6,
                var r when r >= 11 && r <= 12 => 7,
                var r when r >= 13 && r <= 14 => 8,
                15 => 9,
                var r when r >= 16 && r <= 18 => 10,
                19 => 11,
                20 => 12,
                var r when r >= 21 && r <= 22 => 13,
                23 => 14,
                var r when r >= 24 && r <= 25 => 15,
                var r when r >= 26 && r <= 27 => 16,
                var r when r >= 28 && r <= 29 => 17,
                30 => 18,
                var r when r >= 31 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 3 => 1,
                4 => 2,
                var r when r >= 5 && r <= 6 => 3,
                var r when r >= 7 && r <= 8 => 4,
                var r when r >= 9 && r <= 10 => 5,
                11 => 6,
                var r when r >= 12 && r <= 13 => 7,
                14 => 8,
                var r when r >= 15 && r <= 16 => 9,
                17 => 10,
                var r when r >= 18 && r <= 19 => 11,
                20 => 12,
                var r when r >= 21 && r <= 22 => 13,
                23 => 14,
                24 => 15,
                25 => 16,
                26 => 17,
                var r when r >= 27 && r <= 28 => 18,
                var r when r >= 29 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
