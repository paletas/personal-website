using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class SevenYearLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                0 => 1,
                1 => 2,
                var r when r >= 2 && r <= 3 => 3,
                4 => 4,
                5 => 5,
                6 => 6,
                7 => 7,
                8 => 8,
                9 => 10,
                10 => 12,
                11 => 15,
                12 => 16,
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
                var r when r >= 0 && r <= 12 => 1,
                var r when r >= 13 && r <= 17 => 2,
                var r when r >= 18 && r <= 22 => 3,
                var r when r >= 23 && r <= 24 => 4,
                var r when r >= 25 && r <= 26 => 5,
                var r when r >= 27 && r <= 31 => 6,
                var r when r >= 32 && r <= 33 => 7,
                var r when r >= 34 && r <= 36 => 8,
                var r when r >= 37 && r <= 40 => 9,
                var r when r >= 41 && r <= 44 => 10,
                var r when r >= 45 && r <= 50 => 11,
                var r when r >= 51 && r <= 55 => 12,
                var r when r >= 56 && r <= 58 => 13,
                var r when r >= 59 && r <= 60 => 14,
                var r when r >= 61 && r <= 62 => 15,
                63 => 16,
                64 => 17,
                65 => 18,
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
                1 => 4,
                2 => 5,
                3 => 6,
                4 => 7,
                5 => 8,
                6 => 9,
                7 => 11,
                8 => 12,
                9 => 13,
                10 => 14,
                11 => 15,
                12 => 17,
                13 => 18,
                var r when r >= 14 && r <= 36 => 19,
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
                var r when r >= 3 && r <= 4 => 5,
                5 => 6,
                var r when r >= 6 && r <= 10 => 7,
                var r when r >= 11 && r <= 15 => 8,
                var r when r >= 16 && r <= 18 => 9,
                var r when r >= 19 && r <= 21 => 10,
                var r when r >= 22 && r <= 26 => 11,
                var r when r >= 27 && r <= 30 => 12,
                var r when r >= 31 && r <= 32 => 13,
                var r when r >= 33 && r <= 35 => 14,
                var r when r >= 36 && r <= 41 => 15,
                var r when r >= 42 && r <= 46 => 16,
                var r when r >= 47 && r <= 49 => 17,
                var r when r >= 50 && r <= 51 => 18,
                var r when r >= 52 && r <= 69 => 19,
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
                var r when r >= 0 && r <= 2 => 1,
                var r when r >= 3 && r <= 4 => 2,
                5 => 3,
                6 => 4,
                7 => 6,
                8 => 8,
                9 => 9,
                10 => 10,
                11 => 11,
                12 => 13,
                13 => 14,
                14 => 15,
                15 => 16,
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
                var r when r >= 0 && r <= 3 => 1,
                4 => 2,
                5 => 3,
                6 => 4,
                7 => 5,
                8 => 6,
                9 => 7,
                var r when r >= 10 && r <= 11 => 8,
                12 => 9,
                13 => 10,
                14 => 11,
                15 => 12,
                16 => 13,
                17 => 14,
                18 => 15,
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
                0 => 1,
                1 => 2,
                2 => 3,
                3 => 4,
                var r when r >= 4 && r <= 5 => 5,
                6 => 6,
                7 => 7,
                var r when r >= 8 && r <= 10 => 8,
                var r when r >= 11 && r <= 13 => 9,
                var r when r >= 14 && r <= 16 => 10,
                var r when r >= 17 && r <= 18 => 11,
                var r when r >= 19 && r <= 20 => 12,
                21 => 13,
                var r when r >= 22 && r <= 23 => 14,
                var r when r >= 24 && r <= 25 => 15,
                var r when r >= 26 && r <= 30 => 16,
                var r when r >= 31 && r <= 32 => 17,
                var r when r >= 33 && r <= 34 => 18,
                var r when r >= 35 && r <= 64 => 19,
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
                0 => 1,
                1 => 2,
                2 => 3,
                3 => 4,
                4 => 5,
                5 => 7,
                6 => 8,
                7 => 9,
                8 => 10,
                9 => 12,
                10 => 13,
                11 => 15,
                12 => 16,
                13 => 18,
                var r when r >= 14 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 3 => 1,
                4 => 2,
                5 => 3,
                6 => 4,
                7 => 6,
                var r when r >= 8 && r <= 9 => 7,
                10 => 8,
                var r when r >= 11 && r <= 12 => 9,
                13 => 10,
                var r when r >= 14 && r <= 15 => 11,
                var r when r >= 16 && r <= 17 => 12,
                18 => 13,
                var r when r >= 19 && r <= 20 => 14,
                var r when r >= 21 && r <= 22 => 15,
                23 => 16,
                24 => 17,
                25 => 18,
                var r when r >= 26 && r <= 28 => 19,
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
                var r when r >= 2 && r <= 3 => 3,
                var r when r >= 4 && r <= 6 => 4,
                var r when r >= 7 && r <= 8 => 5,
                var r when r >= 9 && r <= 10 => 6,
                var r when r >= 11 && r <= 12 => 7,
                var r when r >= 13 && r <= 14 => 8,
                var r when r >= 15 && r <= 17 => 9,
                var r when r >= 18 && r <= 20 => 10,
                var r when r >= 21 && r <= 22 => 11,
                var r when r >= 23 && r <= 25 => 12,
                var r when r >= 26 && r <= 27 => 13,
                28 => 14,
                29 => 15,
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
                0 => 4,
                1 => 6,
                2 => 7,
                3 => 8,
                4 => 9,
                5 => 10,
                6 => 11,
                7 => 13,
                8 => 14,
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
                0 => 1,
                var r when r >= 1 && r <= 3 => 2,
                var r when r >= 4 && r <= 6 => 3,
                var r when r >= 7 && r <= 10 => 4,
                var r when r >= 11 && r <= 12 => 5,
                13 => 6,
                var r when r >= 14 && r <= 15 => 7,
                var r when r >= 16 && r <= 17 => 8,
                var r when r >= 18 && r <= 19 => 9,
                var r when r >= 20 && r <= 22 => 10,
                var r when r >= 23 && r <= 24 => 11,
                var r when r >= 25 && r <= 26 => 12,
                var r when r >= 27 && r <= 28 => 13,
                29 => 14,
                var r when r >= 30 && r <= 31 => 15,
                var r when r >= 35 && r <= 35 => 16,
                var r when r >= 36 && r <= 39 => 17,
                var r when r >= 40 && r <= 42 => 18,
                var r when r >= 43 && r <= 45 => 19,
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
                3 => 4,
                4 => 5,
                5 => 6,
                var r when r >= 6 && r <= 7 => 7,
                var r when r >= 8 && r <= 9 => 8,
                var r when r >= 10 && r <= 11 => 9,
                12 => 10,
                13 => 11,
                14 => 12,
                var r when r >= 15 && r <= 16 => 13,
                var r when r >= 17 && r <= 18 => 14,
                19 => 15,
                20 => 17,
                21 => 18,
                var r when r >= 22 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
