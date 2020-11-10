using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class SixteenYearLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 7 => 1,
                8 => 2,
                9 => 3,
                10 => 4,
                11 => 5,
                12 => 6,
                var r when r >= 13 && r <= 14 => 7,
                var r when r >= 15 && r <= 16 => 8,
                17 => 9,
                18 => 10,
                19 => 11,
                20 => 12,
                21 => 13,
                22 => 14,
                23 => 15,
                24 => 16,
                var r when r >= 25 && r <= 26 => 17,
                27 => 18,
                var r when r >= 28 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 34 => 1,
                var r when r >= 35 && r <= 37 => 2,
                var r when r >= 38 && r <= 43 => 3,
                var r when r >= 44 && r <= 48 => 4,
                var r when r >= 49 && r <= 53 => 5,
                var r when r >= 54 && r <= 56 => 6,
                var r when r >= 57 && r <= 59 => 7,
                var r when r >= 60 && r <= 63 => 8,
                var r when r >= 64 && r <= 67 => 9,
                var r when r >= 68 && r <= 71 => 10,
                var r when r >= 72 && r <= 74 => 11,
                var r when r >= 75 && r <= 78 => 12,
                var r when r >= 79 && r <= 82 => 13,
                var r when r >= 83 && r <= 85 => 14,
                var r when r >= 86 && r <= 87 => 15,
                var r when r >= 88 && r <= 90 => 16,
                var r when r >= 91 && r <= 92 => 17,
                var r when r >= 93 && r <= 94 => 18,
                var r when r >= 95 && r <= 119 => 19,
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
                var r when r >= 0 && r <= 10 => 1,
                var r when r >= 11 && r <= 12 => 2,
                13 => 3,
                14 => 4,
                var r when r >= 15 && r <= 17 => 5,
                18 => 6,
                var r when r >= 19 && r <= 20 => 7,
                21 => 8,
                var r when r >= 22 && r <= 23 => 9,
                24 => 10,
                25 => 11,
                26 => 12,
                var r when r >= 27 && r <= 28 => 13,
                29 => 14,
                30 => 15,
                31 => 16,
                32 => 17,
                33 => 18,
                var r when r >= 34 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 23 => 1,
                var r when r >= 24 && r <= 28 => 2,
                var r when r >= 29 && r <= 32 => 3,
                var r when r >= 33 && r <= 37 => 4,
                var r when r >= 38 && r <= 40 => 5,
                var r when r >= 41 && r <= 42 => 6,
                var r when r >= 43 && r <= 47 => 7,
                var r when r >= 48 && r <= 51 => 8,
                var r when r >= 52 && r <= 54 => 9,
                var r when r >= 55 && r <= 56 => 10,
                var r when r >= 57 && r <= 58 => 11,
                var r when r >= 59 && r <= 60 => 12,
                var r when r >= 61 && r <= 62 => 13,
                var r when r >= 63 && r <= 64 => 14,
                var r when r >= 65 && r <= 66 => 15,
                67 => 16,
                68 => 17,
                69 => 18,
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
                var r when r >= 19 && r <= 20 => 13,
                21 => 14,
                22 => 15,
                23 => 16,
                var r when r >= 24 && r <= 25 => 17,
                26 => 18,
                var r when r >= 27 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 15 => 1,
                16 => 2,
                17 => 3,
                18 => 5,
                19 => 6,
                20 => 7,
                var r when r >= 21 && r <= 22 => 8,
                23 => 9,
                24 => 11,
                25 => 13,
                26 => 14,
                27 => 15,
                28 => 16,
                29 => 17,
                30 => 18,
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
                var r when r >= 0 && r <= 12 => 1,
                var r when r >= 13 && r <= 16 => 2,
                var r when r >= 17 && r <= 20 => 3,
                var r when r >= 21 && r <= 23 => 4,
                var r when r >= 24 && r <= 25 => 5,
                26 => 6,
                var r when r >= 27 && r <= 30 => 7,
                var r when r >= 31 && r <= 34 => 8,
                var r when r >= 35 && r <= 37 => 9,
                var r when r >= 38 && r <= 41 => 10,
                var r when r >= 42 && r <= 44 => 11,
                var r when r >= 45 && r <= 46 => 12,
                var r when r >= 47 && r <= 48 => 13,
                var r when r >= 49 && r <= 51 => 14,
                var r when r >= 52 && r <= 53 => 15,
                var r when r >= 54 && r <= 55 => 16,
                var r when r >= 56 && r <= 57 => 17,
                var r when r >= 58 && r <= 59 => 18,
                var r when r >= 60 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 10 => 1,
                var r when r >= 11 && r <= 12 => 2,
                13 => 3,
                var r when r >= 14 && r <= 15 => 4,
                var r when r >= 16 && r <= 17 => 5,
                18 => 6,
                19 => 7,
                20 => 8,
                var r when r >= 21 && r <= 22 => 9,
                var r when r >= 23 && r <= 24 => 10,
                25 => 11,
                26 => 13,
                27 => 14,
                28 => 15,
                29 => 17,
                30 => 18,
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
                var r when r >= 0 && r <= 12 => 1,
                var r when r >= 13 && r <= 14 => 2,
                15 => 3,
                16 => 4,
                17 => 5,
                18 => 6,
                19 => 7,
                var r when r >= 20 && r <= 21 => 8,
                var r when r >= 22 && r <= 23 => 9,
                24 => 10,
                25 => 11,
                26 => 13,
                27 => 15,
                28 => 16,
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
                var r when r >= 0 && r <= 17 => 1,
                var r when r >= 18 && r <= 19 => 2,
                var r when r >= 20 && r <= 21 => 3,
                var r when r >= 22 && r <= 23 => 4,
                var r when r >= 24 && r <= 25 => 5,
                var r when r >= 26 && r <= 27 => 6,
                var r when r >= 28 && r <= 29 => 7,
                var r when r >= 30 && r <= 31 => 8,
                32 => 9,
                var r when r >= 33 && r <= 34 => 10,
                35 => 11,
                36 => 12,
                var r when r >= 37 && r <= 38 => 13,
                39 => 14,
                var r when r >= 40 && r <= 41 => 15,
                42 => 16,
                43 => 17,
                44 => 18,
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
                var r when r >= 0 && r <= 9 => 1,
                var r when r >= 10 && r <= 11 => 2,
                var r when r >= 12 && r <= 13 => 3,
                14 => 4,
                var r when r >= 15 && r <= 16 => 5,
                17 => 6,
                18 => 7,
                19 => 8,
                var r when r >= 20 && r <= 21 => 9,
                22 => 10,
                23 => 11,
                24 => 12,
                var r when r >= 25 && r <= 26 => 13,
                27 => 14,
                28 => 15,
                29 => 16,
                30 => 17,
                31 => 18,
                var r when r >= 32 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 16 => 1,
                var r when r >= 17 && r <= 18 => 2,
                var r when r >= 19 && r <= 20 => 3,
                21 => 4,
                var r when r >= 22 && r <= 23 => 5,
                24 => 6,
                var r when r >= 25 && r <= 26 => 7,
                var r when r >= 27 && r <= 29 => 8,
                var r when r >= 30 && r <= 31 => 9,
                32 => 10,
                var r when r >= 33 && r <= 34 => 11,
                var r when r >= 35 && r <= 36 => 12,
                37 => 13,
                var r when r >= 38 && r <= 39 => 14,
                40 => 15,
                41 => 16,
                42 => 17,
                43 => 18,
                var r when r >= 44 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 16 => 1,
                var r when r >= 17 && r <= 19 => 2,
                var r when r >= 20 && r <= 23 => 3,
                var r when r >= 24 && r <= 26 => 4,
                var r when r >= 27 && r <= 28 => 5,
                var r when r >= 29 && r <= 30 => 6,
                var r when r >= 31 && r <= 32 => 7,
                var r when r >= 33 && r <= 34 => 8,
                var r when r >= 35 && r <= 37 => 9,
                var r when r >= 38 && r <= 40 => 10,
                var r when r >= 41 && r <= 42 => 11,
                var r when r >= 43 && r <= 44 => 12,
                var r when r >= 45 && r <= 46 => 13,
                var r when r >= 47 && r <= 48 => 14,
                var r when r >= 49 && r <= 51 => 15,
                var r when r >= 52 && r <= 53 => 16,
                54 => 17,
                var r when r >= 55 && r <= 56 => 18,
                var r when r >= 57 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
