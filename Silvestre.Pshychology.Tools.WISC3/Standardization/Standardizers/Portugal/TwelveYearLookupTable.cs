using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class TwelveYearLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 6 => 1,
                7 => 2,
                8 => 3,
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
                var r when r >= 0 && r <= 21 => 1,
                var r when r >= 22 && r <= 25 => 2,
                var r when r >= 26 && r <= 29 => 3,
                var r when r >= 30 && r <= 33 => 4,
                var r when r >= 34 && r <= 36 => 5,
                var r when r >= 37 && r <= 39 => 6,
                var r when r >= 40 && r <= 44 => 7,
                var r when r >= 45 && r <= 47 => 8,
                var r when r >= 48 && r <= 50 => 9,
                var r when r >= 51 && r <= 54 => 10,
                var r when r >= 55 && r <= 56 => 11,
                var r when r >= 57 && r <= 58 => 12,
                var r when r >= 59 && r <= 61 => 13,
                var r when r >= 62 && r <= 63 => 14,
                var r when r >= 64 && r <= 66 => 15,
                67 => 16,
                var r when r >= 68 && r <= 69 => 17,
                var r when r >= 70 && r <= 71 => 18,
                var r when r >= 72 && r <= 119 => 19,
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
                var r when r >= 0 && r <= 4 => 1,
                var r when r >= 5 && r <= 6 => 2,
                7 => 3,
                8 => 4,
                9 => 5,
                10 => 6,
                11 => 7,
                var r when r >= 12 && r <= 13 => 8,
                var r when r >= 14 && r <= 15 => 9,
                16 => 10,
                17 => 11,
                18 => 12,
                19 => 13,
                var r when r >= 20 && r <= 21 => 14,
                var r when r >= 22 && r <= 23 => 15,
                24 => 16,
                var r when r >= 25 && r <= 26 => 17,
                27 => 18,
                var r when r >= 28 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 12 => 2,
                var r when r >= 13 && r <= 16 => 3,
                var r when r >= 17 && r <= 20 => 4,
                var r when r >= 21 && r <= 24 => 5,
                var r when r >= 25 && r <= 30 => 6,
                var r when r >= 31 && r <= 35 => 7,
                var r when r >= 36 && r <= 39 => 8,
                var r when r >= 40 && r <= 43 => 9,
                var r when r >= 44 && r <= 47 => 10,
                var r when r >= 48 && r <= 50 => 11,
                var r when r >= 51 && r <= 54 => 12,
                var r when r >= 55 && r <= 56 => 13,
                var r when r >= 57 && r <= 58 => 14,
                var r when r >= 59 && r <= 60 => 15,
                var r when r >= 61 && r <= 63 => 16,
                64 => 17,
                65 => 18,
                var r when r >= 66 && r <= 69 => 19,
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
                9 => 6,
                10 => 7,
                11 => 8,
                12 => 9,
                var r when r >= 13 && r <= 14 => 10,
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
                var r when r >= 0 && r <= 11 => 1,
                12 => 2,
                13 => 3,
                14 => 4,
                15 => 5,
                16 => 6,
                17 => 7,
                18 => 8,
                var r when r >= 19 && r <= 20 => 9,
                21 => 10,
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

        TestDescriptorPerAge IStandardizerLookupTable.GetImageDispositionDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetImageDispositionStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 6 => 1,
                var r when r >= 7 && r <= 8 => 2,
                var r when r >= 9 && r <= 11 => 3,
                var r when r >= 12 && r <= 14 => 4,
                var r when r >= 15 && r <= 16 => 5,
                var r when r >= 17 && r <= 21 => 6,
                var r when r >= 22 && r <= 24 => 7,
                var r when r >= 25 && r <= 27 => 8,
                var r when r >= 28 && r <= 30 => 9,
                var r when r >= 31 && r <= 33 => 10,
                var r when r >= 34 && r <= 36 => 11,
                var r when r >= 37 && r <= 39 => 12,
                var r when r >= 40 && r <= 42 => 13,
                var r when r >= 43 && r <= 44 => 14,
                var r when r >= 45 && r <= 46 => 15,
                var r when r >= 47 && r <= 48 => 16,
                var r when r >= 49 && r <= 50 => 17,
                var r when r >= 51 && r <= 52 => 18,
                var r when r >= 53 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 7 => 1,
                8 => 2,
                9 => 3,
                10 => 4,
                11 => 5,
                12 => 6,
                13 => 7,
                14 => 8,
                15 => 9,
                var r when r >= 16 && r <= 17 => 10,
                18 => 11,
                19 => 12,
                20 => 13,
                21 => 14,
                22 => 15,
                23 => 16,
                var r when r >= 24 && r <= 25 => 17,
                var r when r >= 26 && r <= 27 => 18,
                var r when r >= 28 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 10 => 2,
                var r when r >= 11 && r <= 12 => 3,
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
                var r when r >= 0 && r <= 9 => 1,
                var r when r >= 10 && r <= 13 => 2,
                var r when r >= 14 && r <= 16 => 3,
                var r when r >= 17 && r <= 18 => 4,
                var r when r >= 19 && r <= 21 => 5,
                var r when r >= 22 && r <= 23 => 6,
                var r when r >= 24 && r <= 25 => 7,
                var r when r >= 26 && r <= 28 => 8,
                var r when r >= 29 && r <= 30 => 9,
                var r when r >= 31 && r <= 32 => 10,
                33 => 11,
                34 => 12,
                35 => 13,
                36 => 14,
                var r when r >= 37 && r <= 38 => 15,
                39 => 16,
                40 => 17,
                41 => 18,
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
                var r when r >= 0 && r <= 2 => 1,
                var r when r >= 3 && r <= 4 => 2,
                5 => 3,
                6 => 4,
                7 => 5,
                var r when r >= 8 && r <= 9 => 6,
                var r when r >= 10 && r <= 11 => 7,
                var r when r >= 12 && r <= 13 => 8,
                14 => 9,
                var r when r >= 15 && r <= 16 => 10,
                17 => 11,
                18 => 12,
                var r when r >= 19 && r <= 20 => 13,
                21 => 14,
                22 => 15,
                23 => 16,
                24 => 17,
                25 => 18,
                var r when r >= 26 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 9 => 1,
                var r when r >= 10 && r <= 11 => 2,
                var r when r >= 12 && r <= 13 => 3,
                var r when r >= 14 && r <= 15 => 4,
                var r when r >= 16 && r <= 17 => 5,
                var r when r >= 18 && r <= 19 => 6,
                20 => 7,
                var r when r >= 21 && r <= 22 => 8,
                23 => 9,
                var r when r >= 24 && r <= 25 => 10,
                var r when r >= 26 && r <= 27 => 11,
                var r when r >= 28 && r <= 29 => 12,
                30 => 13,
                var r when r >= 31 && r <= 32 => 14,
                33 => 15,
                var r when r >= 34 && r <= 35 => 16,
                var r when r >= 36 && r <= 37 => 17,
                38 => 18,
                var r when r >= 39 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 10 => 2,
                var r when r >= 11 && r <= 12 => 3,
                var r when r >= 13 && r <= 14 => 4,
                15 => 5,
                var r when r >= 16 && r <= 17 => 6,
                18 => 7,
                var r when r >= 19 && r <= 21 => 8,
                var r when r >= 22 && r <= 24 => 9,
                var r when r >= 25 && r <= 26 => 10,
                var r when r >= 27 && r <= 28 => 11,
                var r when r >= 29 && r <= 30 => 12,
                var r when r >= 31 && r <= 32 => 13,
                var r when r >= 33 && r <= 34 => 14,
                var r when r >= 35 && r <= 37 => 15,
                var r when r >= 38 && r <= 40 => 16,
                var r when r >= 41 && r <= 42 => 17,
                var r when r >= 43 && r <= 44 => 18,
                var r when r >= 45 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
