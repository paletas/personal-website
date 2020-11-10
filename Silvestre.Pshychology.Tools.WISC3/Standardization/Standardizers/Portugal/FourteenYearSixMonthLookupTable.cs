using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class FourteenYearSixMonthLookupTable : IStandardizerLookupTable
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
                var r when r >= 18 && r <= 19 => 12,
                20 => 13,
                21 => 14,
                22 => 15,
                var r when r >= 23 && r <= 24 => 16,
                25 => 17,
                26 => 18,
                var r when r >= 27 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 31 => 1,
                var r when r >= 32 && r <= 37 => 2,
                var r when r >= 38 && r <= 42 => 3,
                var r when r >= 43 && r <= 47 => 4,
                var r when r >= 48 && r <= 51 => 5,
                var r when r >= 52 && r <= 54 => 6,
                var r when r >= 55 && r <= 56 => 7,
                var r when r >= 57 && r <= 60 => 8,
                var r when r >= 61 && r <= 64 => 9,
                var r when r >= 65 && r <= 67 => 10,
                var r when r >= 68 && r <= 69 => 11,
                var r when r >= 70 && r <= 73 => 12,
                var r when r >= 74 && r <= 77 => 13,
                var r when r >= 78 && r <= 79 => 14,
                var r when r >= 80 && r <= 84 => 15,
                var r when r >= 85 && r <= 87 => 16,
                var r when r >= 88 && r <= 90 => 17,
                var r when r >= 91 && r <= 92 => 18,
                var r when r >= 93 && r <= 119 => 19,
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
                var r when r >= 0 && r <= 9 => 1,
                10 => 2,
                11 => 3,
                12 => 4,
                13 => 5,
                var r when r >= 14 && r <= 15 => 6,
                var r when r >= 16 && r <= 17 => 7,
                18 => 8,
                var r when r >= 19 && r <= 20 => 9,
                21 => 10,
                22 => 11,
                var r when r >= 23 && r <= 24 => 12,
                25 => 13,
                26 => 14,
                27 => 15,
                28 => 16,
                var r when r >= 29 && r <= 30 => 17,
                31 => 18,
                var r when r >= 32 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 19 => 1,
                var r when r >= 20 && r <= 23 => 2,
                var r when r >= 24 && r <= 28 => 3,
                var r when r >= 29 && r <= 32 => 4,
                var r when r >= 33 && r <= 36 => 5,
                var r when r >= 37 && r <= 40 => 6,
                var r when r >= 41 && r <= 44 => 7,
                var r when r >= 45 && r <= 48 => 8,
                var r when r >= 49 && r <= 51 => 9,
                var r when r >= 52 && r <= 54 => 10,
                var r when r >= 55 && r <= 57 => 11,
                var r when r >= 58 && r <= 59 => 12,
                var r when r >= 60 && r <= 61 => 13,
                var r when r >= 62 && r <= 63 => 14,
                var r when r >= 64 && r <= 65 => 15,
                66 => 16,
                67 => 17,
                68 => 18,
                69 => 19,
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
                14 => 9,
                15 => 10,
                16 => 11,
                17 => 12,
                18 => 13,
                19 => 14,
                var r when r >= 20 && r <= 21 => 15,
                22 => 16,
                23 => 17,
                24 => 18,
                var r when r >= 25 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 13 => 1,
                14 => 2,
                15 => 3,
                16 => 4,
                17 => 5,
                18 => 6,
                19 => 7,
                var r when r >= 20 && r <= 21 => 8,
                22 => 9,
                23 => 10,
                24 => 11,
                25 => 13,
                26 => 14,
                27 => 16,
                28 => 17,
                29 => 18,
                30 => 19,
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
                var r when r >= 0 && r <= 10 => 1,
                var r when r >= 11 && r <= 13 => 2,
                var r when r >= 14 && r <= 16 => 3,
                var r when r >= 17 && r <= 19 => 4,
                var r when r >= 20 && r <= 22 => 5,
                var r when r >= 23 && r <= 25 => 6,
                var r when r >= 26 && r <= 28 => 7,
                var r when r >= 29 && r <= 31 => 8,
                var r when r >= 32 && r <= 34 => 9,
                var r when r >= 35 && r <= 38 => 10,
                var r when r >= 39 && r <= 41 => 11,
                var r when r >= 42 && r <= 43 => 12,
                var r when r >= 44 && r <= 45 => 13,
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
                var r when r >= 0 && r <= 10 => 1,
                11 => 2,
                12 => 3,
                13 => 4,
                14 => 5,
                15 => 6,
                var r when r >= 16 && r <= 17 => 7,
                18 => 8,
                var r when r >= 19 && r <= 20 => 9,
                21 => 10,
                22 => 11,
                23 => 12,
                24 => 13,
                25 => 14,
                26 => 15,
                27 => 16,
                28 => 17,
                29 => 18,
                30 => 19,
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
                var r when r >= 0 && r <= 11 => 1,
                var r when r >= 12 && r <= 13 => 2,
                14 => 3,
                var r when r >= 15 && r <= 16 => 4,
                17 => 5,
                18 => 6,
                19 => 7,
                20 => 8,
                var r when r >= 21 && r <= 22 => 9,
                23 => 10,
                24 => 11,
                25 => 12,
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
                var r when r >= 0 && r <= 16 => 1,
                var r when r >= 17 && r <= 18 => 2,
                var r when r >= 19 && r <= 20 => 3,
                var r when r >= 21 && r <= 22 => 4,
                var r when r >= 23 && r <= 25 => 5,
                26 => 6,
                var r when r >= 27 && r <= 28 => 7,
                29 => 8,
                var r when r >= 30 && r <= 31 => 9,
                var r when r >= 32 && r <= 33 => 10,
                var r when r >= 34 && r <= 35 => 11,
                36 => 12,
                37 => 13,
                38 => 14,
                var r when r >= 39 && r <= 40 => 15,
                41 => 16,
                42 => 17,
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
                var r when r >= 0 && r <= 6 => 1,
                var r when r >= 7 && r <= 8 => 2,
                9 => 3,
                10 => 4,
                var r when r >= 11 && r <= 12 => 5,
                13 => 6,
                var r when r >= 14 && r <= 15 => 7,
                var r when r >= 16 && r <= 17 => 8,
                18 => 9,
                var r when r >= 19 && r <= 20 => 10,
                21 => 11,
                22 => 12,
                23 => 13,
                24 => 14,
                25 => 15,
                var r when r >= 26 && r <= 27 => 16,
                28 => 17,
                29 => 18,
                var r when r >= 30 && r <= 33 => 19,
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
                var r when r >= 0 && r <= 14 => 1,
                var r when r >= 15 && r <= 17 => 2,
                18 => 3,
                var r when r >= 19 && r <= 20 => 4,
                var r when r >= 21 && r <= 22 => 5,
                23 => 6,
                var r when r >= 24 && r <= 25 => 7,
                var r when r >= 26 && r <= 27 => 8,
                var r when r >= 28 && r <= 29 => 9,
                30 => 10,
                var r when r >= 31 && r <= 32 => 11,
                33 => 12,
                var r when r >= 34 && r <= 35 => 13,
                36 => 14,
                var r when r >= 37 && r <= 38 => 15,
                39 => 16,
                40 => 17,
                41 => 18,
                var r when r >= 42 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 13 => 1,
                var r when r >= 14 && r <= 15 => 2,
                var r when r >= 16 && r <= 17 => 3,
                var r when r >= 18 && r <= 19 => 4,
                var r when r >= 20 && r <= 21 => 5,
                var r when r >= 22 && r <= 24 => 6,
                var r when r >= 25 && r <= 26 => 7,
                var r when r >= 27 && r <= 29 => 8,
                var r when r >= 30 && r <= 32 => 9,
                var r when r >= 33 && r <= 34 => 10,
                var r when r >= 35 && r <= 37 => 11,
                var r when r >= 38 && r <= 39 => 12,
                var r when r >= 40 && r <= 41 => 13,
                var r when r >= 42 && r <= 43 => 14,
                var r when r >= 44 && r <= 45 => 15,
                var r when r >= 46 && r <= 47 => 16,
                var r when r >= 48 && r <= 49 => 17,
                var r when r >= 50 && r <= 52 => 18,
                var r when r >= 53 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
