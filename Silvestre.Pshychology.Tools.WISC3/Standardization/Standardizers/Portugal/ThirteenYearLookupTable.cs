using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class ThirteenYearLookupTable : IStandardizerLookupTable
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
                12 => 7,
                var r when r >= 13 && r <= 14 => 8,
                15 => 9,
                16 => 10,
                17 => 11,
                18 => 13,
                19 => 14,
                20 => 15,
                21 => 16,
                22 => 17,
                var r when r >= 23 && r <= 24 => 18,
                var r when r >= 25 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 25 => 1,
                var r when r >= 26 && r <= 29 => 2,
                var r when r >= 30 && r <= 33 => 3,
                var r when r >= 34 && r <= 37 => 4,
                var r when r >= 38 && r <= 39 => 5,
                var r when r >= 40 && r <= 43 => 6,
                var r when r >= 44 && r <= 47 => 7,
                var r when r >= 48 && r <= 52 => 8,
                var r when r >= 53 && r <= 56 => 9,
                var r when r >= 57 && r <= 60 => 10,
                var r when r >= 61 && r <= 63 => 11,
                var r when r >= 64 && r <= 69 => 12,
                var r when r >= 70 && r <= 74 => 13,
                var r when r >= 75 && r <= 76 => 14,
                var r when r >= 77 && r <= 78 => 15,
                79 => 16,
                80 => 17,
                var r when r >= 81 && r <= 82 => 18,
                var r when r >= 83 && r <= 119 => 19,
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
                var r when r >= 0 && r <= 6 => 1,
                var r when r >= 7 && r <= 8 => 2,
                var r when r >= 9 && r <= 10 => 3,
                11 => 4,
                12 => 5,
                13 => 6,
                14 => 7,
                var r when r >= 15 && r <= 16 => 8,
                var r when r >= 17 && r <= 18 => 9,
                19 => 10,
                20 => 11,
                21 => 12,
                22 => 13,
                var r when r >= 23 && r <= 24 => 14,
                25 => 15,
                var r when r >= 26 && r <= 27 => 16,
                28 => 17,
                29 => 18,
                var r when r >= 30 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 14 => 1,
                var r when r >= 15 && r <= 19 => 2,
                var r when r >= 20 && r <= 24 => 3,
                var r when r >= 25 && r <= 29 => 4,
                var r when r >= 30 && r <= 32 => 5,
                var r when r >= 33 && r <= 37 => 6,
                var r when r >= 38 && r <= 40 => 7,
                var r when r >= 41 && r <= 43 => 8,
                var r when r >= 44 && r <= 47 => 9,
                var r when r >= 48 && r <= 50 => 10,
                var r when r >= 51 && r <= 55 => 11,
                var r when r >= 56 && r <= 57 => 12,
                var r when r >= 58 && r <= 59 => 13,
                var r when r >= 60 && r <= 61 => 14,
                var r when r >= 62 && r <= 63 => 15,
                var r when r >= 64 && r <= 65 => 16,
                66 => 17,
                67 => 18,
                var r when r >= 68 && r <= 69 => 19,
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
                8 => 4,
                9 => 5,
                10 => 6,
                11 => 7,
                12 => 8,
                13 => 9,
                14 => 10,
                15 => 11,
                16 => 12,
                17 => 13,
                18 => 14,
                19 => 15,
                20 => 16,
                21 => 17,
                22 => 18,
                var r when r >= 23 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 12 => 1,
                13 => 2,
                14 => 3,
                15 => 4,
                16 => 5,
                17 => 6,
                18 => 7,
                var r when r >= 19 && r <= 20 => 8,
                21 => 9,
                22 => 11,
                23 => 12,
                24 => 13,
                25 => 15,
                26 => 16,
                27 => 17,
                28 => 18,
                var r when r >= 29 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 7 => 1,
                var r when r >= 8 && r <= 9 => 2,
                var r when r >= 10 && r <= 12 => 3,
                var r when r >= 13 && r <= 15 => 4,
                var r when r >= 16 && r <= 20 => 5,
                var r when r >= 21 && r <= 22 => 6,
                var r when r >= 23 && r <= 25 => 7,
                var r when r >= 26 && r <= 28 => 8,
                var r when r >= 29 && r <= 32 => 9,
                var r when r >= 33 && r <= 35 => 10,
                var r when r >= 36 && r <= 39 => 11,
                var r when r >= 40 && r <= 42 => 12,
                var r when r >= 43 && r <= 45 => 13,
                var r when r >= 46 && r <= 47 => 14,
                var r when r >= 48 && r <= 50 => 15,
                var r when r >= 51 && r <= 52 => 16,
                var r when r >= 53 && r <= 54 => 17,
                var r when r >= 55 && r <= 56 => 18,
                var r when r >= 57 && r <= 64 => 19,
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
                24 => 14,
                25 => 15,
                26 => 16,
                27 => 17,
                28 => 18,
                var r when r >= 29 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 9 => 1,
                var r when r >= 10 && r <= 11 => 2,
                12 => 3,
                13 => 4,
                14 => 5,
                15 => 6,
                var r when r >= 16 && r <= 17 => 7,
                18 => 8,
                var r when r >= 19 && r <= 20 => 9,
                var r when r >= 21 && r <= 22 => 10,
                23 => 11,
                24 => 12,
                25 => 13,
                26 => 14,
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
                var r when r >= 0 && r <= 13 => 1,
                var r when r >= 14 && r <= 16 => 2,
                var r when r >= 17 && r <= 18 => 3,
                var r when r >= 19 && r <= 20 => 4,
                var r when r >= 21 && r <= 22 => 5,
                var r when r >= 23 && r <= 24 => 6,
                var r when r >= 25 && r <= 26 => 7,
                var r when r >= 27 && r <= 28 => 8,
                var r when r >= 29 && r <= 31 => 9,
                var r when r >= 32 && r <= 33 => 10,
                34 => 11,
                35 => 12,
                36 => 13,
                var r when r >= 37 && r <= 38 => 14,
                39 => 15,
                40 => 16,
                var r when r >= 41 && r <= 42 => 17,
                43 => 18,
                44 => 19,
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
                var r when r >= 0 && r <= 4 => 1,
                var r when r >= 5 && r <= 6 => 2,
                7 => 3,
                var r when r >= 8 && r <= 9 => 4,
                10 => 5,
                var r when r >= 11 && r <= 12 => 6,
                13 => 7,
                var r when r >= 14 && r <= 15 => 8,
                var r when r >= 16 && r <= 17 => 9,
                18 => 10,
                19 => 11,
                20 => 12,
                21 => 13,
                22 => 14,
                23 => 15,
                24 => 16,
                25 => 17,
                26 => 18,
                var r when r >= 27 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 11 => 1,
                var r when r >= 12 && r <= 13 => 2,
                14 => 3,
                var r when r >= 15 && r <= 16 => 4,
                var r when r >= 17 && r <= 18 => 5,
                var r when r >= 19 && r <= 20 => 6,
                var r when r >= 21 && r <= 22 => 7,
                var r when r >= 23 && r <= 24 => 8,
                var r when r >= 25 && r <= 26 => 9,
                var r when r >= 27 && r <= 28 => 10,
                var r when r >= 29 && r <= 30 => 11,
                31 => 12,
                var r when r >= 32 && r <= 33 => 13,
                34 => 14,
                35 => 15,
                var r when r >= 36 && r <= 37 => 16,
                var r when r >= 38 && r <= 39 => 17,
                40 => 18,
                var r when r >= 41 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 10 => 1,
                var r when r >= 11 && r <= 12 => 2,
                var r when r >= 13 && r <= 14 => 3,
                var r when r >= 15 && r <= 16 => 4,
                var r when r >= 17 && r <= 19 => 5,
                var r when r >= 20 && r <= 21 => 6,
                var r when r >= 22 && r <= 23 => 7,
                var r when r >= 24 && r <= 26 => 8,
                var r when r >= 27 && r <= 28 => 9,
                var r when r >= 29 && r <= 30 => 10,
                var r when r >= 31 && r <= 32 => 11,
                var r when r >= 33 && r <= 35 => 12,
                var r when r >= 36 && r <= 38 => 13,
                var r when r >= 39 && r <= 40 => 14,
                var r when r >= 41 && r <= 42 => 15,
                var r when r >= 43 && r <= 44 => 16,
                45 => 17,
                46 => 18,
                var r when r >= 47 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
