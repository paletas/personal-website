using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class TenYearLookupTable : IStandardizerLookupTable
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
                var r when r >= 27 && r <= 29 => 5,
                var r when r >= 30 && r <= 31 => 6,
                var r when r >= 32 && r <= 35 => 7,
                var r when r >= 36 && r <= 38 => 8,
                var r when r >= 39 && r <= 42 => 9,
                var r when r >= 43 && r <= 45 => 10,
                var r when r >= 46 && r <= 48 => 11,
                var r when r >= 49 && r <= 51 => 12,
                var r when r >= 52 && r <= 54 => 13,
                var r when r >= 55 && r <= 56 => 14,
                var r when r >= 57 && r <= 58 => 15,
                59 => 16,
                60 => 17,
                var r when r >= 61 && r <= 62 => 18,
                var r when r >= 63 && r <= 119 => 19,
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
                var r when r >= 7 && r <= 8 => 6,
                9 => 7,
                10 => 8,
                var r when r >= 11 && r <= 12 => 9,
                13 => 10,
                14 => 11,
                15 => 12,
                16 => 13,
                var r when r >= 17 && r <= 18 => 14,
                19 => 15,
                20 => 16,
                21 => 17,
                22 => 18,
                var r when r >= 23 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 5 => 1,
                var r when r >= 6 && r <= 10 => 2,
                var r when r >= 11 && r <= 13 => 3,
                var r when r >= 14 && r <= 17 => 4,
                var r when r >= 18 && r <= 19 => 5,
                var r when r >= 20 && r <= 22 => 6,
                var r when r >= 23 && r <= 28 => 7,
                var r when r >= 29 && r <= 32 => 8,
                var r when r >= 33 && r <= 34 => 9,
                var r when r >= 35 && r <= 37 => 10,
                var r when r >= 38 && r <= 41 => 11,
                var r when r >= 42 && r <= 43 => 12,
                var r when r >= 44 && r <= 45 => 13,
                var r when r >= 46 && r <= 50 => 14,
                var r when r >= 51 && r <= 53 => 15,
                var r when r >= 54 && r <= 56 => 16,
                var r when r >= 57 && r <= 59 => 17,
                60 => 18,
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
                var r when r >= 0 && r <= 9 => 1,
                10 => 2,
                11 => 3,
                12 => 4,
                13 => 5,
                14 => 6,
                15 => 7,
                16 => 8,
                var r when r >= 17 && r <= 18 => 9,
                19 => 10,
                20 => 11,
                21 => 13,
                22 => 14,
                var r when r >= 23 && r <= 24 => 15,
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
                var r when r >= 0 && r <= 4 => 1,
                var r when r >= 5 && r <= 8 => 2,
                var r when r >= 9 && r <= 11 => 3,
                12 => 4,
                var r when r >= 13 && r <= 14 => 5,
                var r when r >= 15 && r <= 17 => 6,
                var r when r >= 18 && r <= 19 => 7,
                var r when r >= 20 && r <= 21 => 8,
                var r when r >= 22 && r <= 24 => 9,
                var r when r >= 25 && r <= 26 => 10,
                var r when r >= 27 && r <= 28 => 11,
                var r when r >= 29 && r <= 31 => 12,
                var r when r >= 32 && r <= 35 => 13,
                var r when r >= 36 && r <= 37 => 14,
                var r when r >= 38 && r <= 39 => 15,
                var r when r >= 40 && r <= 41 => 16,
                var r when r >= 42 && r <= 43 => 17,
                var r when r >= 44 && r <= 45 => 18,
                var r when r >= 46 && r <= 64 => 19,
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
                21 => 11,
                var r when r >= 22 && r <= 23 => 12,
                24 => 13,
                25 => 14,
                26 => 15,
                27 => 17,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 10 => 2,
                var r when r >= 11 && r <= 13 => 3,
                var r when r >= 14 && r <= 16 => 4,
                var r when r >= 17 && r <= 18 => 5,
                var r when r >= 19 && r <= 20 => 6,
                var r when r >= 21 && r <= 22 => 7,
                var r when r >= 23 && r <= 24 => 8,
                var r when r >= 25 && r <= 27 => 9,
                var r when r >= 28 && r <= 29 => 10,
                30 => 11,
                31 => 12,
                var r when r >= 32 && r <= 33 => 13,
                34 => 14,
                var r when r >= 35 && r <= 36 => 15,
                37 => 16,
                38 => 17,
                39 => 18,
                var r when r >= 40 && r <= 44 => 19,
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
                var r when r >= 0 && r <= 1 => 3,
                2 => 4,
                3 => 5,
                4 => 6,
                5 => 7,
                var r when r >= 6 && r <= 7 => 8,
                var r when r >= 8 && r <= 9 => 9,
                var r when r >= 10 && r <= 11 => 10,
                var r when r >= 12 && r <= 13 => 11,
                14 => 12,
                var r when r >= 15 && r <= 16 => 13,
                17 => 14,
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
                var r when r >= 0 && r <= 7 => 1,
                8 => 2,
                9 => 3,
                10 => 4,
                var r when r >= 11 && r <= 12 => 5,
                var r when r >= 13 && r <= 14 => 6,
                var r when r >= 15 && r <= 16 => 7,
                var r when r >= 17 && r <= 18 => 8,
                var r when r >= 19 && r <= 20 => 9,
                21 => 10,
                var r when r >= 22 && r <= 23 => 11,
                24 => 12,
                25 => 13,
                var r when r >= 26 && r <= 27 => 14,
                var r when r >= 28 && r <= 29 => 15,
                30 => 16,
                31 => 17,
                32 => 18,
                var r when r >= 33 && r <= 45 => 19,
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
                var r when r >= 6 && r <= 7 => 2,
                var r when r >= 8 && r <= 9 => 3,
                var r when r >= 10 && r <= 11 => 4,
                12 => 5,
                13 => 6,
                var r when r >= 14 && r <= 15 => 7,
                16 => 8,
                var r when r >= 17 && r <= 18 => 9,
                var r when r >= 19 && r <= 20 => 10,
                21 => 11,
                var r when r >= 22 && r <= 23 => 12,
                var r when r >= 24 && r <= 25 => 13,
                var r when r >= 26 && r <= 27 => 14,
                var r when r >= 28 && r <= 29 => 15,
                var r when r >= 30 && r <= 31 => 16,
                var r when r >= 32 && r <= 33 => 17,
                var r when r >= 34 && r <= 35 => 18,
                var r when r >= 36 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
