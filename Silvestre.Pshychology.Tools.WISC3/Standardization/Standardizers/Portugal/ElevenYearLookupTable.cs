using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class ElevenYearLookupTable : IStandardizerLookupTable
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
                9 => 5,
                10 => 7,
                11 => 8,
                var r when r >= 12 && r <= 13 => 9,
                14 => 10,
                15 => 11,
                16 => 13,
                17 => 14,
                18 => 15,
                19 => 16,
                var r when r >= 20 && r <= 21 => 17,
                var r when r >= 22 && r <= 23 => 18,
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
                var r when r >= 0 && r <= 17 => 1,
                var r when r >= 18 && r <= 22 => 2,
                var r when r >= 23 && r <= 27 => 3,
                var r when r >= 28 && r <= 31 => 4,
                var r when r >= 32 && r <= 33 => 5,
                var r when r >= 34 && r <= 36 => 6,
                var r when r >= 37 && r <= 39 => 7,
                var r when r >= 40 && r <= 44 => 8,
                var r when r >= 45 && r <= 46 => 9,
                var r when r >= 47 && r <= 48 => 10,
                var r when r >= 49 && r <= 50 => 11,
                var r when r >= 51 && r <= 55 => 12,
                var r when r >= 56 && r <= 57 => 13,
                var r when r >= 58 && r <= 60 => 14,
                var r when r >= 61 && r <= 62 => 15,
                var r when r >= 63 && r <= 64 => 16,
                65 => 17,
                var r when r >= 66 && r <= 67 => 18,
                var r when r >= 68 && r <= 119 => 19,
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
                var r when r >= 3 && r <= 4 => 2,
                5 => 3,
                var r when r >= 6 && r <= 7 => 4,
                var r when r >= 8 && r <= 9 => 5,
                10 => 6,
                11 => 7,
                12 => 8,
                var r when r >= 13 && r <= 14 => 9,
                15 => 10,
                16 => 11,
                17 => 12,
                18 => 13,
                var r when r >= 19 && r <= 21 => 14,
                22 => 15,
                23 => 16,
                24 => 17,
                25 => 18,
                var r when r >= 26 && r <= 36 => 19,
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
                var r when r >= 29 && r <= 34 => 8,
                var r when r >= 35 && r <= 38 => 9,
                var r when r >= 39 && r <= 42 => 10,
                var r when r >= 43 && r <= 46 => 11,
                var r when r >= 47 && r <= 50 => 12,
                var r when r >= 51 && r <= 52 => 13,
                var r when r >= 53 && r <= 56 => 14,
                var r when r >= 57 && r <= 59 => 15,
                60 => 16,
                61 => 17,
                var r when r >= 62 && r <= 63 => 18,
                var r when r >= 64 && r <= 69 => 19,
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
                8 => 5,
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
                21 => 18,
                var r when r >= 22 && r <= 30 => 19,
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
                var r when r >= 14 && r <= 15 => 6,
                16 => 7,
                17 => 8,
                var r when r >= 18 && r <= 19 => 9,
                20 => 10,
                21 => 11,
                22 => 12,
                23 => 13,
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
                var r when r >= 13 && r <= 15 => 5,
                var r when r >= 16 && r <= 17 => 6,
                var r when r >= 18 && r <= 21 => 7,
                var r when r >= 22 && r <= 24 => 8,
                var r when r >= 25 && r <= 26 => 9,
                var r when r >= 27 && r <= 28 => 10,
                var r when r >= 29 && r <= 31 => 11,
                var r when r >= 32 && r <= 36 => 12,
                var r when r >= 37 && r <= 38 => 13,
                var r when r >= 39 && r <= 41 => 14,
                var r when r >= 42 && r <= 43 => 15,
                var r when r >= 44 && r <= 45 => 16,
                var r when r >= 46 && r <= 47 => 17,
                var r when r >= 48 && r <= 49 => 18,
                var r when r >= 50 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 6 => 1,
                7 => 2,
                8 => 3,
                9 => 4,
                10 => 5,
                11 => 6,
                12 => 7,
                13 => 8,
                var r when r >= 14 && r <= 15 => 9,
                16 => 10,
                17 => 11,
                18 => 12,
                19 => 13,
                20 => 14,
                21 => 15,
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
                var r when r >= 24 && r <= 25 => 13,
                26 => 15,
                27 => 16,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 11 => 2,
                var r when r >= 12 && r <= 13 => 3,
                var r when r >= 14 && r <= 16 => 4,
                var r when r >= 17 && r <= 18 => 5,
                var r when r >= 19 && r <= 21 => 6,
                var r when r >= 22 && r <= 23 => 7,
                var r when r >= 24 && r <= 25 => 8,
                var r when r >= 26 && r <= 27 => 9,
                var r when r >= 28 && r <= 29 => 10,
                var r when r >= 30 && r <= 31 => 11,
                32 => 12,
                var r when r >= 33 && r <= 34 => 13,
                35 => 14,
                var r when r >= 36 && r <= 37 => 15,
                38 => 16,
                39 => 17,
                var r when r >= 40 && r <= 41 => 18,
                var r when r >= 42 && r <= 44 => 19,
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
                0 => 1,
                1 => 2,
                var r when r >= 2 && r <= 3 => 3,
                var r when r >= 4 && r <= 5 => 4,
                6 => 5,
                7 => 6,
                8 => 7,
                var r when r >= 9 && r <= 10 => 8,
                var r when r >= 11 && r <= 12 => 9,
                var r when r >= 13 && r <= 14 => 10,
                var r when r >= 15 && r <= 16 => 11,
                17 => 12,
                18 => 13,
                var r when r >= 19 && r <= 20 => 14,
                21 => 15,
                22 => 16,
                23 => 17,
                24 => 18,
                var r when r >= 25 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 10 => 2,
                var r when r >= 11 && r <= 12 => 3,
                var r when r >= 13 && r <= 14 => 4,
                var r when r >= 15 && r <= 16 => 5,
                17 => 6,
                var r when r >= 18 && r <= 19 => 7,
                var r when r >= 20 && r <= 21 => 8,
                var r when r >= 22 && r <= 23 => 9,
                24 => 10,
                25 => 11,
                var r when r >= 26 && r <= 27 => 12,
                28 => 13,
                29 => 14,
                var r when r >= 30 && r <= 31 => 15,
                32 => 16,
                33 => 17,
                34 => 18,
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
                var r when r >= 0 && r <= 6 => 1,
                var r when r >= 7 && r <= 8 => 2,
                var r when r >= 9 && r <= 10 => 3,
                var r when r >= 11 && r <= 12 => 4,
                var r when r >= 13 && r <= 14 => 5,
                15 => 6,
                var r when r >= 16 && r <= 17 => 7,
                var r when r >= 18 && r <= 19 => 8,
                var r when r >= 20 && r <= 21 => 9,
                var r when r >= 22 && r <= 23 => 10,
                var r when r >= 24 && r <= 25 => 11,
                var r when r >= 26 && r <= 27 => 12,
                var r when r >= 28 && r <= 29 => 13,
                var r when r >= 30 && r <= 31 => 14,
                var r when r >= 32 && r <= 33 => 15,
                var r when r >= 34 && r <= 35 => 16,
                36 => 17,
                37 => 18,
                var r when r >= 38 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
