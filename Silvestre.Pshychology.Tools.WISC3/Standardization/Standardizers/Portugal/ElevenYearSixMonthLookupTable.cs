using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class ElevenYearSixMonthLookupTable : IStandardizerLookupTable
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
                10 => 6,
                11 => 7,
                12 => 8,
                13 => 9,
                14 => 10,
                15 => 11,
                16 => 12,
                17 => 13,
                18 => 15,
                var r when r >= 19 && r <= 20 => 16,
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
                var r when r >= 0 && r <= 20 => 1,
                var r when r >= 21 && r <= 25 => 2,
                var r when r >= 26 && r <= 28 => 3,
                var r when r >= 29 && r <= 32 => 4,
                var r when r >= 33 && r <= 35 => 5,
                var r when r >= 36 && r <= 38 => 6,
                var r when r >= 39 && r <= 42 => 7,
                var r when r >= 43 && r <= 45 => 8,
                var r when r >= 46 && r <= 48 => 9,
                var r when r >= 49 && r <= 50 => 10,
                var r when r >= 51 && r <= 55 => 11,
                var r when r >= 56 && r <= 57 => 12,
                var r when r >= 58 && r <= 59 => 13,
                var r when r >= 60 && r <= 62 => 14,
                var r when r >= 63 && r <= 64 => 15,
                var r when r >= 65 && r <= 66 => 16,
                67 => 17,
                var r when r >= 68 && r <= 69 => 18,
                var r when r >= 70 && r <= 119 => 19,
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
                5 => 2,
                6 => 3,
                var r when r >= 7 && r <= 8 => 4,
                9 => 5,
                10 => 6,
                11 => 7,
                12 => 8,
                var r when r >= 13 && r <= 14 => 9,
                15 => 10,
                16 => 11,
                var r when r >= 17 && r <= 18 => 12,
                19 => 13,
                var r when r >= 20 && r <= 21 => 14,
                var r when r >= 22 && r <= 23 => 15,
                24 => 16,
                25 => 17,
                26 => 18,
                var r when r >= 27 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 7 => 1,
                var r when r >= 8 && r <= 10 => 2,
                var r when r >= 11 && r <= 15 => 3,
                var r when r >= 16 && r <= 20 => 4,
                var r when r >= 21 && r <= 24 => 5,
                var r when r >= 25 && r <= 29 => 6,
                var r when r >= 30 && r <= 33 => 7,
                var r when r >= 34 && r <= 38 => 8,
                var r when r >= 39 && r <= 41 => 9,
                var r when r >= 42 && r <= 45 => 10,
                var r when r >= 46 && r <= 49 => 11,
                var r when r >= 50 && r <= 52 => 12,
                var r when r >= 53 && r <= 55 => 13,
                var r when r >= 56 && r <= 57 => 14,
                var r when r >= 58 && r <= 60 => 15,
                var r when r >= 61 && r <= 62 => 16,
                63 => 17,
                64 => 18,
                var r when r >= 65 && r <= 69 => 19,
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
                var r when r >= 0 && r <= 10 => 1,
                11 => 2,
                12 => 3,
                13 => 4,
                14 => 5,
                15 => 6,
                16 => 7,
                var r when r >= 17 && r <= 18 => 8,
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
                var r when r >= 12 && r <= 13 => 4,
                var r when r >= 14 && r <= 16 => 5,
                var r when r >= 17 && r <= 18 => 6,
                var r when r >= 19 && r <= 22 => 7,
                var r when r >= 23 && r <= 25 => 8,
                var r when r >= 26 && r <= 27 => 9,
                var r when r >= 28 && r <= 30 => 10,
                var r when r >= 31 && r <= 34 => 11,
                var r when r >= 35 && r <= 37 => 12,
                var r when r >= 39 && r <= 41 => 13,
                var r when r >= 42 && r <= 43 => 14,
                var r when r >= 44 && r <= 45 => 15,
                var r when r >= 46 && r <= 48 => 16,
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
                var r when r >= 0 && r <= 6 => 1,
                7 => 2,
                var r when r >= 8 && r <= 9 => 3,
                10 => 4,
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
                24 => 17,
                var r when r >= 25 && r <= 26 => 18,
                var r when r >= 27 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 7 => 1,
                8 => 2,
                9 => 3,
                var r when r >= 10 && r <= 11 => 4,
                12 => 5,
                var r when r >= 13 && r <= 14 => 6,
                var r when r >= 15 && r <= 16 => 7,
                var r when r >= 17 && r <= 18 => 8,
                19 => 9,
                var r when r >= 20 && r <= 21 => 10,
                22 => 11,
                var r when r >= 23 && r <= 24 => 12,
                25 => 13,
                26 => 14,
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
                var r when r >= 0 && r <= 9 => 1,
                var r when r >= 10 && r <= 13 => 2,
                var r when r >= 14 && r <= 15 => 3,
                var r when r >= 16 && r <= 17 => 4,
                var r when r >= 18 && r <= 20 => 5,
                var r when r >= 21 && r <= 22 => 6,
                var r when r >= 23 && r <= 24 => 7,
                var r when r >= 25 && r <= 26 => 8,
                var r when r >= 27 && r <= 28 => 9,
                var r when r >= 29 && r <= 30 => 10,
                31 => 11,
                var r when r >= 32 && r <= 33 => 12,
                var r when r >= 34 && r <= 35 => 13,
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
                var r when r >= 0 && r <= 1 => 1,
                2 => 2,
                var r when r >= 3 && r <= 4 => 3,
                5 => 4,
                6 => 5,
                var r when r >= 7 && r <= 8 => 6,
                9 => 7,
                var r when r >= 10 && r <= 11 => 8,
                var r when r >= 12 && r <= 13 => 9,
                var r when r >= 14 && r <= 15 => 10,
                16 => 11,
                var r when r >= 17 && r <= 18 => 12,
                19 => 13,
                20 => 14,
                var r when r >= 21 && r <= 22 => 15,
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
                var r when r >= 0 && r <= 8 => 1,
                var r when r >= 9 && r <= 10 => 2,
                var r when r >= 11 && r <= 12 => 3,
                var r when r >= 13 && r <= 14 => 4,
                var r when r >= 15 && r <= 16 => 5,
                var r when r >= 17 && r <= 18 => 6,
                19 => 7,
                var r when r >= 20 && r <= 21 => 8,
                var r when r >= 22 && r <= 23 => 9,
                24 => 10,
                var r when r >= 25 && r <= 26 => 11,
                27 => 12,
                var r when r >= 28 && r <= 29 => 13,
                var r when r >= 30 && r <= 31 => 14,
                32 => 15,
                33 => 16,
                var r when r >= 34 && r <= 35 => 17,
                var r when r >= 36 && r <= 37 => 18,
                var r when r >= 38 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 7 => 1,
                var r when r >= 8 && r <= 10 => 2,
                var r when r >= 11 && r <= 12 => 3,
                13 => 4,
                var r when r >= 14 && r <= 15 => 5,
                16 => 6,
                var r when r >= 17 && r <= 18 => 7,
                var r when r >= 19 && r <= 20 => 8,
                var r when r >= 21 && r <= 22 => 9,
                var r when r >= 23 && r <= 24 => 10,
                var r when r >= 25 && r <= 26 => 11,
                var r when r >= 27 && r <= 29 => 12,
                var r when r >= 30 && r <= 31 => 13,
                var r when r >= 32 && r <= 33 => 14,
                var r when r >= 34 && r <= 35 => 15,
                var r when r >= 36 && r <= 38 => 16,
                var r when r >= 39 && r <= 41 => 17,
                var r when r >= 42 && r <= 43 => 18,
                var r when r >= 44 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
