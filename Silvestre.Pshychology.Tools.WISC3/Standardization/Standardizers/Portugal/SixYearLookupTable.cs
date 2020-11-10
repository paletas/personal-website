using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class SixYearLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
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
                8 => 13,
                9 => 15,
                10 => 17,
                11 => 18,
                var r when r >= 12 && r <= 30 => 19,
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
                var r when r >= 10 && r <= 12 => 3,
                var r when r >= 13 && r <= 17 => 4,
                var r when r >= 18 && r <= 21 => 5,
                var r when r >= 22 && r <= 23 => 6,
                var r when r >= 24 && r <= 26 => 7,
                var r when r >= 27 && r <= 28 => 8,
                var r when r >= 29 && r <= 33 => 9,
                var r when r >= 34 && r <= 36 => 10,
                var r when r >= 37 && r <= 41 => 11,
                var r when r >= 42 && r <= 46 => 12,
                var r when r >= 47 && r <= 50 => 13,
                var r when r >= 51 && r <= 54 => 14,
                var r when r >= 55 && r <= 58 => 15,
                var r when r >= 59 && r <= 60 => 16,
                var r when r >= 61 && r <= 62 => 17,
                63 => 18,
                var r when r >= 64 && r <= 65 => 19,
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
                0 => 4,
                1 => 5,
                2 => 7,
                3 => 8,
                4 => 9,
                5 => 11,
                6 => 12,
                7 => 14,
                8 => 16,
                9 => 17,
                10 => 18,
                var r when r >= 11 && r <= 36 => 19,
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
                var r when r >= 7 && r <= 9 => 8,
                var r when r >= 10 && r <= 12 => 9,
                var r when r >= 13 && r <= 15 => 10,
                var r when r >= 16 && r <= 19 => 11,
                var r when r >= 20 && r <= 24 => 12,
                var r when r >= 25 && r <= 27 => 13,
                var r when r >= 28 && r <= 31 => 14,
                var r when r >= 32 && r <= 34 => 15,
                var r when r >= 35 && r <= 38 => 16,
                var r when r >= 39 && r <= 40 => 17,
                var r when r >= 41 && r <= 42 => 18,
                var r when r >= 43 && r <= 69 => 19,
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
                0 => 1,
                1 => 2,
                2 => 3,
                3 => 4,
                4 => 5,
                5 => 6,
                6 => 7,
                7 => 8,
                8 => 9,
                9 => 10,
                10 => 11,
                11 => 13,
                12 => 15,
                13 => 16,
                14 => 17,
                15 => 18,
                var r when r >= 16 && r <= 30 => 19,
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
                3 => 4,
                4 => 5,
                5 => 6,
                6 => 7,
                var r when r >= 7 && r <= 8 => 8,
                9 => 9,
                var r when r >= 10 && r <= 11 => 10,
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

        TestDescriptorPerAge IStandardizerLookupTable.GetImageDispositionDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetImageDispositionStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                0 => 4,
                1 => 5,
                2 => 6,
                3 => 7,
                var r when r >= 4 && r <= 5 => 8,
                var r when r >= 6 && r <= 8 => 9,
                9 => 10,
                var r when r >= 10 && r <= 11 => 11,
                var r when r >= 12 && r <= 13 => 12,
                var r when r >= 14 && r <= 15 => 13,
                var r when r >= 16 && r <= 17 => 14,
                var r when r >= 18 && r <= 19 => 15,
                20 => 16,
                21 => 17,
                var r when r >= 22 && r <= 23 => 18,
                var r when r >= 24 && r <= 64 => 19,
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
                4 => 8,
                5 => 9,
                6 => 11,
                7 => 13,
                8 => 15,
                9 => 16,
                10 => 17,
                var r when r >= 11 && r <= 30 => 19,
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
                0 => 1,
                1 => 2,
                2 => 3,
                var r when r >= 3 && r <= 4 => 4,
                5 => 5,
                6 => 6,
                7 => 7,
                8 => 8,
                var r when r >= 9 && r <= 10 => 9,
                var r when r >= 11 && r <= 12 => 10,
                13 => 11,
                14 => 12,
                var r when r >= 15 && r <= 16 => 13,
                var r when r >= 17 && r <= 18 => 14,
                19 => 15,
                20 => 16,
                21 => 17,
                22 => 18,
                var r when r >= 23 && r <= 28 => 19,
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
                7 => 6,
                var r when r >= 8 && r <= 9 => 7,
                var r when r >= 10 && r <= 11 => 8,
                var r when r >= 12 && r <= 14 => 9,
                var r when r >= 15 && r <= 16 => 10,
                var r when r >= 17 && r <= 19 => 11,
                var r when r >= 20 && r <= 22 => 12,
                var r when r >= 23 && r <= 24 => 13,
                25 => 14,
                var r when r >= 26 && r <= 28 => 15,
                var r when r >= 29 && r <= 30 => 16,
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
                6 => 14,
                7 => 15,
                8 => 17,
                9 => 18,
                var r when r >= 10 && r <= 33 => 19,
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
                0 => 4,
                var r when r >= 1 && r <= 2 => 5,
                var r when r >= 3 && r <= 4 => 6,
                var r when r >= 5 && r <= 7 => 7,
                var r when r >= 8 && r <= 11 => 8,
                var r when r >= 12 && r <= 13 => 9,
                var r when r >= 14 && r <= 15 => 10,
                var r when r >= 16 && r <= 17 => 11,
                var r when r >= 18 && r <= 20 => 12,
                var r when r >= 21 && r <= 22 => 13,
                var r when r >= 23 && r <= 25 => 14,
                var r when r >= 26 && r <= 27 => 15,
                var r when r >= 28 && r <= 29 => 16,
                var r when r >= 30 && r <= 32 => 17,
                var r when r >= 33 && r <= 34 => 18,
                var r when r >= 35 && r <= 45 => 19,
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
                0 => 2,
                1 => 3,
                2 => 4,
                3 => 5,
                4 => 6,
                5 => 7,
                6 => 8,
                var r when r >= 7 && r <= 8 => 9,
                var r when r >= 9 && r <= 10 => 10,
                11 => 11,
                12 => 12,
                13 => 13,
                14 => 14,
                15 => 15,
                16 => 16,
                17 => 17,
                18 => 18,
                var r when r >= 19 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
