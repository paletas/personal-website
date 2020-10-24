﻿using Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers;
using System;

namespace Silvestre.Pshychology.Tools.WISC3.Tests.Standardizers.Portugal
{
    internal class SevenYearSixMonthLookupTable : IStandardizerLookupTable
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
                3 => 2,
                var r when r >= 4 && r <= 5 => 3,
                6 => 4,
                7 => 6,
                8 => 8,
                9 => 9,
                10 => 10,
                11 => 12,
                12 => 13,
                13 => 15,
                14 => 16,
                15 => 17,
                16 => 18,
                var r when r >= 17 && r <= 30 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                var r when r >= 0 && r <= 16 => 1,
                var r when r >= 17 && r <= 19 => 2,
                var r when r >= 20 && r <= 22 => 3,
                var r when r >= 23 && r <= 24 => 4,
                var r when r >= 25 && r <= 26 => 5,
                var r when r >= 27 && r <= 31 => 6,
                var r when r >= 32 && r <= 33 => 7,
                var r when r >= 34 && r <= 36 => 8,
                var r when r >= 37 && r <= 41 => 9,
                var r when r >= 42 && r <= 45 => 10,
                var r when r >= 46 && r <= 51 => 11,
                var r when r >= 52 && r <= 55 => 12,
                var r when r >= 56 && r <= 59 => 13,
                60 => 14,
                var r when r >= 61 && r <= 62 => 15,
                63 => 16,
                64 => 17,
                65 => 18,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                2 => 5,
                3 => 6,
                4 => 7,
                5 => 8,
                6 => 9,
                7 => 10,
                8 => 11,
                var r when r >= 9 && r <= 10 => 12,
                11 => 13,
                12 => 14,
                13 => 15,
                14 => 16,
                15 => 18,
                var r when r >= 16 && r <= 36 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                0 => 1,
                1 => 2,
                2 => 3,
                var r when r >= 3 && r <= 4 => 4,
                5 => 5,
                var r when r >= 6 && r <= 9 => 6,
                var r when r >= 10 && r <= 13 => 7,
                var r when r >= 14 && r <= 17 => 8,
                var r when r >= 18 && r <= 20 => 9,
                var r when r >= 21 && r <= 25 => 10,
                var r when r >= 26 && r <= 29 => 11,
                var r when r >= 30 && r <= 33 => 12,
                var r when r >= 34 && r <= 38 => 13,
                var r when r >= 39 && r <= 42 => 14,
                var r when r >= 43 && r <= 46 => 15,
                var r when r >= 47 && r <= 49 => 16,
                var r when r >= 50 && r <= 53 => 17,
                var r when r >= 54 && r <= 57 => 18,
                var r when r >= 58 && r <= 69 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                7 => 6,
                8 => 7,
                9 => 9,
                10 => 10,
                11 => 11,
                12 => 12,
                13 => 13,
                14 => 14,
                15 => 15,
                16 => 16,
                17 => 17,
                18 => 18,
                var r when r >= 19 && r <= 30 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                var r when r >= 0 && r <= 3 => 1,
                4 => 2,
                var r when r >= 5 && r <= 6 => 3,
                7 => 4,
                8 => 5,
                9 => 6,
                10 => 7,
                var r when r >= 11 && r <= 12 => 8,
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
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                0 => 1,
                1 => 2,
                2 => 3,
                var r when r >= 3 && r <= 4 => 4,
                5 => 5,
                var r when r >= 6 && r <= 7 => 6,
                var r when r >= 8 && r <= 9 => 7,
                var r when r >= 10 && r <= 12 => 8,
                var r when r >= 13 && r <= 15 => 9,
                var r when r >= 16 && r <= 18 => 10,
                var r when r >= 19 && r <= 20 => 11,
                var r when r >= 21 && r <= 22 => 12,
                var r when r >= 23 && r <= 25 => 13,
                var r when r >= 26 && r <= 28 => 14,
                var r when r >= 29 && r <= 31 => 15,
                32 => 16,
                var r when r >= 33 && r <= 34 => 17,
                var r when r >= 35 && r <= 37 => 18,
                var r when r >= 38 && r <= 64 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                0 => 1,
                var r when r >= 1 && r <= 2 => 2,
                3 => 3,
                4 => 4,
                5 => 6,
                6 => 7,
                7 => 8,
                8 => 9,
                9 => 10,
                10 => 11,
                11 => 13,
                12 => 14,
                13 => 15,
                var r when r >= 14 && r <= 15 => 16,
                16 => 17,
                17 => 18,
                var r when r >= 18 && r <= 30 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                var r when r >= 0 && r <= 3 => 1,
                4 => 2,
                5 => 3,
                6 => 4,
                7 => 5,
                8 => 6,
                var r when r >= 9 && r <= 10 => 7,
                11 => 8,
                var r when r >= 12 && r <= 13 => 9,
                var r when r >= 14 && r <= 15 => 10,
                var r when r >= 16 && r <= 17 => 11,
                18 => 12,
                var r when r >= 19 && r <= 20 => 13,
                var r when r >= 21 && r <= 22 => 14,
                var r when r >= 23 && r <= 24 => 15,
                25 => 16,
                26 => 17,
                var r when r >= 27 && r <= 28 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                var r when r >= 0 && r <= 1 => 1,
                2 => 2,
                var r when r >= 3 && r <= 5 => 3,
                6 => 4,
                var r when r >= 7 && r <= 8 => 5,
                var r when r >= 9 && r <= 10 => 6,
                var r when r >= 11 && r <= 13 => 7,
                var r when r >= 14 && r <= 16 => 8,
                var r when r >= 17 && r <= 19 => 9,
                var r when r >= 20 && r <= 21 => 10,
                var r when r >= 22 && r <= 23 => 11,
                var r when r >= 24 && r <= 26 => 12,
                var r when r >= 27 && r <= 28 => 13,
                29 => 14,
                var r when r >= 30 && r <= 31 => 15,
                32 => 16,
                var r when r >= 33 && r <= 34 => 17,
                var r when r >= 35 && r <= 36 => 18,
                var r when r >= 37 && r <= 44 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                2 => 7,
                3 => 8,
                4 => 9,
                5 => 10,
                6 => 11,
                7 => 12,
                8 => 13,
                9 => 14,
                10 => 15,
                11 => 16,
                var r when r >= 12 && r <= 13 => 17,
                14 => 18,
                var r when r >= 15 && r <= 33 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                var r when r >= 0 && r <= 2 => 1,
                var r when r >= 3 && r <= 4 => 2,
                var r when r >= 5 && r <= 7 => 3,
                var r when r >= 8 && r <= 10 => 4,
                var r when r >= 11 && r <= 12 => 5,
                var r when r >= 13 && r <= 14 => 6,
                15 => 7,
                var r when r >= 16 && r <= 17 => 8,
                var r when r >= 18 && r <= 19 => 9,
                var r when r >= 20 && r <= 23 => 10,
                24 => 11,
                var r when r >= 25 && r <= 27 => 12,
                var r when r >= 28 && r <= 29 => 13,
                30 => 14,
                var r when r >= 31 && r <= 32 => 15,
                var r when r >= 33 && r <= 36 => 16,
                var r when r >= 37 && r <= 39 => 17,
                var r when r >= 40 && r <= 43 => 18,
                var r when r >= 44 && r <= 45 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
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
                2 => 2,
                3 => 3,
                4 => 4,
                5 => 5,
                var r when r >= 6 && r <= 7 => 6,
                var r when r >= 8 && r <= 9 => 7,
                var r when r >= 10 && r <= 11 => 8,
                12 => 9,
                var r when r >= 13 && r <= 14 => 10,
                15 => 11,
                var r when r >= 16 && r <= 17 => 12,
                18 => 13,
                19 => 14,
                20 => 15,
                21 => 16,
                var r when r >= 22 && r <= 23 => 17,
                24 => 18,
                var r when r >= 25 && r <= 60 => 19,
                _ => throw new ArgumentOutOfRangeException(nameof(rawResult)),
            };
        }
    }
}
