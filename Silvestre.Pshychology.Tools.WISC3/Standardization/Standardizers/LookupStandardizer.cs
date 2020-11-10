using Silvestre.Pshychology.Tools.WISC3.Tests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers
{
    public abstract class LookupStandardizer : ITestStandardizer
    {
        public IEnumerable<(Age From, Age To)> SupportedAgeIntervals => this.GetLookupTables().Keys;

        public TestDescriptor GetTestDescriptor(TestTypeEnum testType)
        {
            return InternalTestDatabase.GetTestDescriptor(this, testType);
        }

        public IEnumerable<TestDescriptorPerAge> GetTestDescriptorsPerType(TestTypeEnum testType)
        {
            return this.GetLookupTables().Select(t => t.Value).Select(t => InternalTestDatabase.GetTestDescriptorPerAge(t, testType));
        }

        public TestDescriptorPerAge GetTestDescriptorPerAge(TestTypeEnum testType, Age age)
        {
            var lookupTable = this.GetStandardizerTableFor(age);
            return InternalTestDatabase.GetTestDescriptorPerAge(lookupTable, testType);
        }

        public TestResult Standerdization(TestTypeEnum testType, Age age, short rawResult)
        {
            var lookupTable = this.GetStandardizerTableFor(age);
            return testType switch
            {
                TestTypeEnum.Arithmetic => ResultForArithmetic(lookupTable, rawResult),
                TestTypeEnum.Information => ResultForInformation(lookupTable, rawResult),
                TestTypeEnum.Similarities => ResultForSimilarities(lookupTable, rawResult),
                TestTypeEnum.Vocabulary => ResultForVocabulary(lookupTable, rawResult),
                TestTypeEnum.Comprehension => ResultForComprehension(lookupTable, rawResult),
                TestTypeEnum.DigitMemory => ResultForDigitMemory(lookupTable, rawResult),
                TestTypeEnum.ImageCompletion => ResultForImageCompletion(lookupTable, rawResult),
                TestTypeEnum.Code => ResultForCode(lookupTable, rawResult),
                TestTypeEnum.ImageDisposition => ResultForImageDisposition(lookupTable, rawResult),
                TestTypeEnum.Cubes => ResultForCubes(lookupTable, rawResult),
                TestTypeEnum.ObjectComposition => ResultForObjectComposition(lookupTable, rawResult),
                TestTypeEnum.SymbolSearch => ResultForSymbolSearch(lookupTable, rawResult),
                TestTypeEnum.Labyrinth => ResultForLabyrinth(lookupTable, rawResult),
                _ => throw new System.NotImplementedException()
            };
        }

        protected abstract IDictionary<(Age From, Age To), IStandardizerLookupTable> GetLookupTables();

        private IStandardizerLookupTable GetStandardizerTableFor(Age age)
        {
            var lookupTables = this.GetLookupTables();
            
            foreach (var lookupTable in lookupTables.OrderBy(key => key.Key.From))
            {
                var (From, To) = lookupTable.Key;

                if (age.Years <= To.Years && age.Months <= To.Months && age.Days <= To.Days)
                {
                    return lookupTable.Value;
                }
            }

            throw new ArgumentOutOfRangeException(nameof(age), "Age provided is outside of supported range");
        }

        private static TestResult ResultForArithmetic(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetArithmeticStandardizedResult(rawResult);
            return new TestResult(standardResult, null, null, null, null);
        }

        private static TestResult ResultForCode(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetCodeStandardizedResult(rawResult);
            return new TestResult(null, standardResult, null, null, standardResult);
        }

        private static TestResult ResultForComprehension(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetComprehensionStandardizedResult(rawResult);
            return new TestResult(standardResult, null, standardResult, null, null);
        }

        private static TestResult ResultForCubes(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetCubesStandardizedResult(rawResult);
            return new TestResult(null, standardResult, null, standardResult, null);
        }

        private static TestResult ResultForDigitMemory(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetDigitMemoryStandardizedResult(rawResult);
            return new TestResult(standardResult, null, null, null, null);
        }

        private static TestResult ResultForImageCompletion(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetImageCompletionStandardizedResult(rawResult);
            return new TestResult(null, standardResult, null, standardResult, null);
        }

        private static TestResult ResultForImageDisposition(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetImageDispositionStandardizedResult(rawResult);
            return new TestResult(null, standardResult, null, standardResult, null);
        }

        private static TestResult ResultForInformation(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetInformationStandardizedResult(rawResult);
            return new TestResult(standardResult, null, standardResult, null, null);
        }

        private static TestResult ResultForLabyrinth(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetLabyrinthStandardizedResult(rawResult);
            return new TestResult(null, standardResult, null, null, null);
        }

        private static TestResult ResultForObjectComposition(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetObjectCompositionStandardizedResult(rawResult);
            return new TestResult(null, standardResult, null, standardResult, null);
        }

        private static TestResult ResultForSimilarities(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetSimilaritiesStandardizedResult(rawResult);
            return new TestResult(standardResult, null, standardResult, null, null);
        }

        private static TestResult ResultForSymbolSearch(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetSymbolSearchStandardizedResult(rawResult);
            return new TestResult(null, standardResult, null, null, standardResult);
        }

        private static TestResult ResultForVocabulary(IStandardizerLookupTable lookupTable, short rawResult)
        {
            var standardResult = lookupTable.GetVocabularyStandardizedResult(rawResult);
            return new TestResult(standardResult, null, standardResult, null, null);
        }
    }
}
