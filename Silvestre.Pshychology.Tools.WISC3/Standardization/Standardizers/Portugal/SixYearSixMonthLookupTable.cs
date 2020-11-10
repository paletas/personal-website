using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class SixYearSixMonthLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                0 => 2,
                1 => 3,
                2 => 4,
                3 => 5,
                4 => 6,
                5 => 7,
                6 => 8,
                7 => 10,
                8 => 11,
                9 => 12,
                10 => 14,
                11 => 16,
                12 => 17,
                13 => 18,
                var r when r >= 14 && r <= 30 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }

        TestDescriptorPerAge IStandardizerLookupTable.GetCodeDescriptor()
        {
            return new TestDescriptorPerAge((0, 65));
        }

        public short GetCodeStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 7 => 1,
                var r when r >= 8 && r <= 9 => 2,
                var r when r >= 10 && r <= 13 => 3,
                var r when r >= 14 && r <= 18 => 4,
                var r when r >= 19 && r <= 22 => 5,
                var r when r >= 23 && r <= 25 => 6,
                var r when r >= 26 && r <= 28 => 7,
                var r when r >= 29 && r <= 33 => 8,
                var r when r >= 34 && r <= 36 => 9,
                var r when r >= 37 && r <= 40 => 10,
                var r when r >= 41 && r <= 45 => 11,
                var r when r >= 46 && r <= 50 => 12,
                var r when r >= 51 && r <= 54 => 13,
                var r when r >= 55 && r <= 58 => 14,
                var r when r >= 59 && r <= 60 => 15,
                var r when r >= 61 && r <= 62 => 16,
                63 => 17,
                64 => 18,
                65 => 19,
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
                0 => 3,
                1 => 5,
                2 => 6,
                3 => 8,
                4 => 9,
                5 => 10,
                6 => 11,
                7 => 12,
                8 => 14,
                9 => 15,
                10 => 16,
                11 => 17,
                12 => 18,
                var r when r >= 13 && r <= 36 => 19,
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
                0 => 2,
                1 => 3,
                2 => 4,
                3 => 5,
                4 => 6,
                var r when r >= 5 && r <= 6 => 7,
                var r when r >= 7 && r <= 10 => 8,
                var r when r >= 11 && r <= 15 => 9,
                var r when r >= 16 && r <= 18 => 10,
                var r when r >= 19 && r <= 22 => 11,
                var r when r >= 23 && r <= 27 => 12,
                var r when r >= 28 && r <= 31 => 13,
                var r when r >= 32 && r <= 33 => 14,
                var r when r >= 34 && r <= 38 => 15,
                var r when r >= 39 && r <= 43 => 16,
                var r when r >= 44 && r <= 46 => 17,
                var r when r >= 47 && r <= 49 => 18,
                var r when r >= 50 && r <= 69 => 19,
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
                var r when r >= 0 && r <= 1 => 1,
                2 => 2,
                3 => 3,
                4 => 4,
                5 => 5,
                6 => 6,
                7 => 7,
                8 => 9,
                9 => 10,
                10 => 11,
                11 => 12,
                12 => 14,
                13 => 15,
                14 => 16,
                15 => 17,
                16 => 18,
                var r when r >= 17 && r <= 30 => 19,
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
                0 => 1,
                1 => 2,
                2 => 3,
                var r when r >= 3 && r <= 4 => 4,
                5 => 5,
                6 => 6,
                7 => 7,
                var r when r >= 8 && r <= 9 => 8,
                10 => 9,
                var r when r >= 11 && r <= 12 => 10,
                13 => 11,
                14 => 12,
                15 => 13,
                16 => 14,
                var r when r >= 17 && r <= 18 => 15,
                19 => 16,
                20 => 17,
                21 => 18,
                var r when r >= 22 && r <= 30 => 19,
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
                0 => 3,
                1 => 4,
                2 => 5,
                3 => 6,
                var r when r >= 4 && r <= 5 => 7,
                var r when r >= 6 && r <= 7 => 8,
                var r when r >= 8 && r <= 9 => 9,
                var r when r >= 10 && r <= 11 => 10,
                var r when r >= 12 && r <= 14 => 11,
                var r when r >= 15 && r <= 17 => 12,
                var r when r >= 18 && r <= 19 => 13,
                20 => 14,
                var r when r >= 21 && r <= 23 => 15,
                var r when r >= 24 && r <= 27 => 16,
                var r when r >= 28 && r <= 30 => 17,
                var r when r >= 31 && r <= 32 => 18,
                var r when r >= 33 && r <= 64 => 19,
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
                0 => 2,
                1 => 3,
                2 => 4,
                3 => 6,
                4 => 7,
                5 => 9,
                6 => 10,
                7 => 11,
                8 => 12,
                9 => 14,
                10 => 15,
                11 => 16,
                12 => 17,
                var r when r >= 13 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 1 => 1,
                2 => 2,
                var r when r >= 3 && r <= 4 => 3,
                5 => 4,
                6 => 5,
                7 => 6,
                8 => 7,
                9 => 8,
                10 => 9,
                var r when r >= 11 && r <= 12 => 10,
                13 => 11,
                var r when r >= 14 && r <= 15 => 12,
                var r when r >= 16 && r <= 17 => 13,
                var r when r >= 18 && r <= 19 => 14,
                var r when r >= 20 && r <= 21 => 15,
                22 => 16,
                23 => 17,
                24 => 18,
                var r when r >= 25 && r <= 28 => 19,
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
                0 => 1,
                1 => 2,
                2 => 3,
                var r when r >= 3 && r <= 4 => 4,
                var r when r >= 5 && r <= 6 => 5,
                var r when r >= 7 && r <= 8 => 6,
                var r when r >= 9 && r <= 10 => 7,
                var r when r >= 11 && r <= 12 => 8,
                var r when r >= 13 && r <= 15 => 9,
                var r when r >= 16 && r <= 18 => 10,
                var r when r >= 19 && r <= 21 => 11,
                var r when r >= 22 && r <= 23 => 12,
                var r when r >= 24 && r <= 25 => 13,
                var r when r >= 26 && r <= 27 => 14,
                var r when r >= 28 && r <= 29 => 15,
                30 => 16,
                31 => 17,
                var r when r >= 32 && r <= 33 => 18,
                var r when r >= 34 && r <= 44 => 19,
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
                0 => 5,
                1 => 7,
                2 => 8,
                3 => 9,
                4 => 10,
                5 => 12,
                6 => 13,
                7 => 14,
                8 => 15,
                9 => 16,
                10 => 17,
                11 => 18,
                var r when r >= 12 && r <= 33 => 19,
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
                0 => 3,
                var r when r >= 1 && r <= 2 => 4,
                var r when r >= 3 && r <= 4 => 5,
                var r when r >= 5 && r <= 7 => 6,
                var r when r >= 8 && r <= 10 => 7,
                var r when r >= 11 && r <= 13 => 8,
                var r when r >= 14 && r <= 16 => 9,
                var r when r >= 17 && r <= 18 => 10,
                var r when r >= 19 && r <= 20 => 11,
                var r when r >= 21 && r <= 24 => 12,
                var r when r >= 25 && r <= 26 => 13,
                var r when r >= 27 && r <= 28 => 14,
                var r when r >= 29 && r <= 30 => 15,
                var r when r >= 31 && r <= 32 => 16,
                var r when r >= 33 && r <= 35 => 17,
                var r when r >= 36 && r <= 39 => 18,
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
                0 => 1,
                1 => 2,
                2 => 3,
                3 => 5,
                4 => 6,
                var r when r >= 5 && r <= 6 => 7,
                7 => 8,
                var r when r >= 8 && r <= 9 => 9,
                10 => 10,
                var r when r >= 11 && r <= 12 => 11,
                13 => 12,
                14 => 13,
                var r when r >= 15 && r <= 16 => 14,
                17 => 15,
                18 => 16,
                19 => 17,
                20 => 18,
                var r when r >= 21 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
