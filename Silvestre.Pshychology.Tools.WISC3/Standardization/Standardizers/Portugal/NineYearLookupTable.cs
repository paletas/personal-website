using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class NineYearLookupTable : IStandardizerLookupTable
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
                var r when r >= 10 && r <= 11 => 8,
                12 => 9,
                13 => 10,
                14 => 12,
                15 => 13,
                16 => 14,
                17 => 15,
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
                var r when r >= 0 && r <= 12 => 1,
                var r when r >= 13 && r <= 16 => 2,
                var r when r >= 17 && r <= 21 => 3,
                var r when r >= 22 && r <= 25 => 4,
                var r when r >= 26 && r <= 28 => 5,
                var r when r >= 29 && r <= 30 => 6,
                var r when r >= 31 && r <= 32 => 7,
                var r when r >= 33 && r <= 35 => 8,
                var r when r >= 36 && r <= 37 => 9,
                var r when r >= 38 && r <= 40 => 10,
                var r when r >= 41 && r <= 44 => 11,
                var r when r >= 45 && r <= 46 => 12,
                var r when r >= 47 && r <= 48 => 13,
                var r when r >= 49 && r <= 51 => 14,
                var r when r >= 52 && r <= 53 => 15,
                var r when r >= 54 && r <= 56 => 16,
                var r when r >= 57 && r <= 58 => 17,
                var r when r >= 59 && r <= 60 => 18,
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
                5 => 5,
                6 => 6,
                var r when r >= 7 && r <= 8 => 7,
                9 => 8,
                10 => 9,
                11 => 10,
                12 => 11,
                13 => 12,
                14 => 14,
                15 => 15,
                16 => 16,
                17 => 17,
                18 => 18,
                var r when r >= 19 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 2 => 1,
                var r when r >= 3 && r <= 5 => 2,
                var r when r >= 6 && r <= 10 => 3,
                var r when r >= 11 && r <= 13 => 4,
                var r when r >= 14 && r <= 17 => 5,
                var r when r >= 18 && r <= 19 => 6,
                var r when r >= 20 && r <= 21 => 7,
                var r when r >= 22 && r <= 25 => 8,
                var r when r >= 26 && r <= 29 => 9,
                var r when r >= 30 && r <= 33 => 10,
                var r when r >= 34 && r <= 38 => 11,
                var r when r >= 39 && r <= 40 => 12,
                var r when r >= 41 && r <= 44 => 13,
                var r when r >= 45 && r <= 50 => 14,
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
                8 => 6,
                9 => 7,
                10 => 8,
                11 => 9,
                12 => 11,
                13 => 12,
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
                var r when r >= 0 && r <= 6 => 1,
                7 => 2,
                8 => 3,
                9 => 4,
                10 => 5,
                11 => 6,
                var r when r >= 12 && r <= 13 => 7,
                14 => 8,
                var r when r >= 15 && r <= 16 => 9,
                17 => 10,
                18 => 12,
                19 => 13,
                20 => 14,
                var r when r >= 21 && r <= 22 => 15,
                23 => 16,
                24 => 17,
                var r when r >= 25 && r <= 27 => 18,
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
                var r when r >= 0 && r <= 1 => 1,
                2 => 2,
                var r when r >= 3 && r <= 4 => 3,
                var r when r >= 5 && r <= 7 => 4,
                var r when r >= 8 && r <= 9 => 5,
                var r when r >= 10 && r <= 11 => 6,
                var r when r >= 12 && r <= 14 => 7,
                var r when r >= 15 && r <= 17 => 8,
                var r when r >= 18 && r <= 19 => 9,
                var r when r >= 20 && r <= 21 => 10,
                var r when r >= 22 && r <= 23 => 11,
                var r when r >= 24 && r <= 26 => 12,
                var r when r >= 27 && r <= 31 => 13,
                32 => 14,
                var r when r >= 33 && r <= 34 => 15,
                var r when r >= 35 && r <= 36 => 16,
                var r when r >= 37 && r <= 38 => 17,
                var r when r >= 39 && r <= 40 => 18,
                var r when r >= 41 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 3 => 1,
                4 => 2,
                5 => 3,
                6 => 4,
                7 => 5,
                8 => 6,
                9 => 7,
                10 => 8,
                var r when r >= 11 && r <= 12 => 9,
                13 => 10,
                14 => 11,
                15 => 12,
                16 => 13,
                17 => 14,
                var r when r >= 18 && r <= 19 => 15,
                20 => 16,
                var r when r >= 21 && r <= 22 => 17,
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
                var r when r >= 0 && r <= 5 => 1,
                6 => 2,
                7 => 3,
                8 => 4,
                var r when r >= 9 && r <= 10 => 5,
                11 => 6,
                12 => 7,
                var r when r >= 13 && r <= 14 => 8,
                var r when r >= 15 && r <= 16 => 9,
                var r when r >= 17 && r <= 18 => 10,
                var r when r >= 19 && r <= 20 => 11,
                21 => 12,
                var r when r >= 22 && r <= 23 => 13,
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
                var r when r >= 0 && r <= 5 => 1,
                var r when r >= 6 && r <= 8 => 2,
                var r when r >= 9 && r <= 10 => 3,
                var r when r >= 11 && r <= 12 => 4,
                13 => 5,
                var r when r >= 14 && r <= 15 => 6,
                var r when r >= 16 && r <= 19 => 7,
                var r when r >= 20 && r <= 21 => 8,
                var r when r >= 22 && r <= 23 => 9,
                var r when r >= 24 && r <= 26 => 10,
                var r when r >= 27 && r <= 28 => 11,
                var r when r >= 29 && r <= 30 => 12,
                31 => 13,
                32 => 14,
                33 => 15,
                34 => 16,
                35 => 17,
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
                var r when r >= 5 && r <= 6 => 8,
                7 => 9,
                var r when r >= 8 && r <= 9 => 10,
                10 => 11,
                11 => 12,
                var r when r >= 12 && r <= 13 => 13,
                var r when r >= 14 && r <= 16 => 14,
                17 => 15,
                18 => 16,
                19 => 17,
                20 => 18,
                var r when r >= 21 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 4 => 1,
                var r when r >= 5 && r <= 6 => 2,
                var r when r >= 7 && r <= 8 => 3,
                9 => 4,
                var r when r >= 10 && r <= 11 => 5,
                12 => 6,
                var r when r >= 13 && r <= 14 => 7,
                var r when r >= 15 && r <= 16 => 8,
                var r when r >= 17 && r <= 18 => 9,
                19 => 10,
                20 => 11,
                21 => 12,
                22 => 13,
                var r when r >= 23 && r <= 24 => 14,
                var r when r >= 25 && r <= 26 => 15,
                var r when r >= 27 && r <= 28 => 16,
                29 => 17,
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
                var r when r >= 4 && r <= 6 => 2,
                var r when r >= 7 && r <= 8 => 3,
                9 => 4,
                10 => 5,
                var r when r >= 11 && r <= 12 => 6,
                var r when r >= 13 && r <= 14 => 7,
                15 => 8,
                var r when r >= 16 && r <= 17 => 9,
                var r when r >= 18 && r <= 19 => 10,
                20 => 11,
                21 => 12,
                var r when r >= 22 && r <= 23 => 13,
                24 => 14,
                25 => 15,
                26 => 16,
                var r when r >= 27 && r <= 28 => 17,
                29 => 18,
                var r when r >= 30 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
