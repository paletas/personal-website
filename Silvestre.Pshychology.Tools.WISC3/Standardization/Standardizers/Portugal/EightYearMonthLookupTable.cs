using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    internal class EightYearMonthLookupTable : IStandardizerLookupTable
    {
        TestDescriptorPerAge IStandardizerLookupTable.GetArithmeticDescriptor()
        {
            return new TestDescriptorPerAge((0, 30));
        }

        public short GetArithmeticStandardizedResult(short rawResult)
        {
            return rawResult switch
            {
                var r when r >= 0 && r <= 2 => 1,
                var r when r >= 3 && r <= 4 => 2,
                5 => 3,
                6 => 4,
                7 => 5,
                8 => 6,
                9 => 7,
                10 => 8,
                11 => 9,
                12 => 11,
                13 => 12,
                14 => 13,
                15 => 15,
                16 => 17,
                17 => 18,
                var r when r >= 18 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 10 => 1,
                var r when r >= 11 && r <= 14 => 2,
                var r when r >= 15 && r <= 18 => 3,
                var r when r >= 19 && r <= 22 => 4,
                var r when r >= 23 && r <= 24 => 5,
                var r when r >= 25 && r <= 27 => 6,
                var r when r >= 28 && r <= 29 => 7,
                30 => 8,
                var r when r >= 31 && r <= 33 => 9,
                var r when r >= 34 && r <= 35 => 10,
                var r when r >= 36 && r <= 37 => 11,
                var r when r >= 38 && r <= 40 => 12,
                var r when r >= 41 && r <= 43 => 13,
                var r when r >= 44 && r <= 45 => 14,
                var r when r >= 46 && r <= 48 => 15,
                49 => 16,
                var r when r >= 50 && r <= 51 => 17,
                var r when r >= 52 && r <= 53 => 18,
                var r when r >= 54 && r <= 119 => 19,
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
                0 => 2,
                1 => 3,
                2 => 4,
                3 => 5,
                4 => 6,
                5 => 7,
                var r when r >= 6 && r <= 7 => 8,
                8 => 9,
                9 => 10,
                10 => 11,
                11 => 12,
                12 => 13,
                13 => 14,
                14 => 15,
                15 => 17,
                16 => 18,
                var r when r >= 17 && r <= 36 => 19,
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
                var r when r >= 0 && r <= 1 => 1,
                var r when r >= 2 && r <= 3 => 2,
                4 => 3,
                5 => 4,
                var r when r >= 6 && r <= 8 => 5,
                var r when r >= 9 && r <= 13 => 6,
                var r when r >= 14 && r <= 16 => 7,
                var r when r >= 17 && r <= 19 => 8,
                var r when r >= 20 && r <= 24 => 9,
                var r when r >= 25 && r <= 29 => 10,
                var r when r >= 30 && r <= 33 => 11,
                var r when r >= 34 && r <= 37 => 12,
                var r when r >= 38 && r <= 41 => 13,
                var r when r >= 42 && r <= 45 => 14,
                var r when r >= 46 && r <= 48 => 15,
                var r when r >= 49 && r <= 52 => 16,
                var r when r >= 53 && r <= 56 => 17,
                var r when r >= 57 && r <= 58 => 18,
                var r when r >= 59 && r <= 69 => 19,
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
                var r when r >= 0 && r <= 3 => 1,
                4 => 2,
                5 => 3,
                6 => 4,
                7 => 5,
                8 => 6,
                9 => 7,
                10 => 9,
                11 => 10,
                12 => 11,
                13 => 12,
                14 => 13,
                15 => 14,
                16 => 15,
                17 => 16,
                18 => 18,
                var r when r >= 19 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 5 => 1,
                6 => 2,
                7 => 3,
                var r when r >= 8 && r <= 9 => 4,
                10 => 5,
                11 => 6,
                12 => 7,
                13 => 8,
                14 => 9,
                var r when r >= 15 && r <= 16 => 10,
                17 => 11,
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
                3 => 3,
                var r when r >= 4 && r <= 5 => 4,
                var r when r >= 6 && r <= 7 => 5,
                var r when r >= 8 && r <= 9 => 6,
                var r when r >= 10 && r <= 11 => 7,
                var r when r >= 12 && r <= 14 => 8,
                var r when r >= 15 && r <= 17 => 9,
                var r when r >= 18 && r <= 20 => 10,
                var r when r >= 21 && r <= 22 => 11,
                var r when r >= 23 && r <= 25 => 12,
                var r when r >= 26 && r <= 28 => 13,
                var r when r >= 29 && r <= 30 => 14,
                var r when r >= 31 && r <= 32 => 15,
                var r when r >= 33 && r <= 34 => 16,
                var r when r >= 35 && r <= 36 => 17,
                var r when r >= 37 && r <= 38 => 18,
                var r when r >= 39 && r <= 64 => 19,
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
                var r when r >= 0 && r <= 2 => 1,
                var r when r >= 3 && r <= 4 => 2,
                5 => 3,
                6 => 4,
                7 => 6,
                8 => 7,
                9 => 8,
                10 => 9,
                11 => 10,
                12 => 12,
                13 => 13,
                14 => 14,
                15 => 15,
                16 => 17,
                17 => 18,
                var r when r >= 18 && r <= 30 => 19,
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
                var r when r >= 0 && r <= 4 => 1,
                5 => 2,
                6 => 3,
                var r when r >= 7 && r <= 8 => 4,
                9 => 5,
                10 => 6,
                var r when r >= 11 && r <= 12 => 7,
                13 => 8,
                var r when r >= 14 && r <= 15 => 9,
                var r when r >= 16 && r <= 17 => 10,
                18 => 11,
                var r when r >= 19 && r <= 20 => 12,
                var r when r >= 21 && r <= 22 => 13,
                23 => 14,
                24 => 15,
                25 => 16,
                26 => 17,
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
                var r when r >= 0 && r <= 2 => 1,
                var r when r >= 3 && r <= 4 => 2,
                5 => 3,
                var r when r >= 6 && r <= 7 => 4,
                var r when r >= 8 && r <= 9 => 5,
                var r when r >= 10 && r <= 11 => 6,
                var r when r >= 12 && r <= 14 => 7,
                var r when r >= 15 && r <= 18 => 8,
                var r when r >= 19 && r <= 20 => 9,
                var r when r >= 21 && r <= 23 => 10,
                var r when r >= 24 && r <= 25 => 11,
                var r when r >= 26 && r <= 27 => 12,
                var r when r >= 28 && r <= 29 => 13,
                30 => 14,
                31 => 15,
                var r when r >= 32 && r <= 33 => 16,
                var r when r >= 34 && r <= 35 => 17,
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
                0 => 4,
                1 => 5,
                2 => 6,
                3 => 7,
                4 => 8,
                var r when r >= 5 && r <= 6 => 9,
                7 => 10,
                8 => 11,
                9 => 12,
                10 => 13,
                11 => 14,
                12 => 15,
                13 => 16,
                14 => 17,
                15 => 18,
                var r when r >= 16 && r <= 33 => 19,
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
                1 => 2,
                2 => 3,
                var r when r >= 3 && r <= 4 => 4,
                var r when r >= 5 && r <= 6 => 5,
                var r when r >= 7 && r <= 8 => 6,
                var r when r >= 9 && r <= 10 => 7,
                var r when r >= 11 && r <= 12 => 8,
                var r when r >= 13 && r <= 14 => 9,
                var r when r >= 15 && r <= 16 => 10,
                var r when r >= 17 && r <= 18 => 11,
                19 => 12,
                20 => 13,
                var r when r >= 21 && r <= 22 => 14,
                var r when r >= 23 && r <= 24 => 15,
                25 => 16,
                26 => 17,
                27 => 18,
                var r when r >= 28 && r <= 45 => 19,
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
                var r when r >= 0 && r <= 1 => 1,
                var r when r >= 2 && r <= 3 => 2,
                4 => 3,
                var r when r >= 5 && r <= 6 => 4,
                var r when r >= 7 && r <= 9 => 5,
                10 => 6,
                var r when r >= 11 && r <= 12 => 7,
                13 => 8,
                var r when r >= 14 && r <= 15 => 9,
                16 => 10,
                var r when r >= 17 && r <= 18 => 11,
                19 => 12,
                20 => 13,
                21 => 14,
                22 => 15,
                23 => 16,
                24 => 17,
                25 => 18,
                var r when r >= 26 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult), $"'{rawResult}' is outside of the supported values."),
            };
        }
    }
}
