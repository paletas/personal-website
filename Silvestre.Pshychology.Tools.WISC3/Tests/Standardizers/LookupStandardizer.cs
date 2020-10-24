 using Silvestre.Pshychology.Tools.WISC3.Tests;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers
{
    public abstract class LookupStandardizer : ITestStandardizer
    {
        protected abstract IStandardizerLookupTable GetStandardizerTableFor(int years, int months, int days);

        public TestDescriptor GetTestDescriptor(TestTypeEnum testType)
        {
            return InternalTestDatabase.GetTestDescriptor(this, testType);
        }

        public TestDescriptorPerAge GetTestDescriptorPerAge(TestTypeEnum testType, (int Years, int Months, int Days) age)
        {
            var lookupTable = this.GetStandardizerTableFor(age.Years, age.Months, age.Days);
            return InternalTestDatabase.GetTestDescriptorPerAge(lookupTable, testType, age);
        }

        public TestDescriptor GetTestDescriptor(TestTypeEnum testType, (int Years, int Months, int Days) age)
        {
            return InternalTestDatabase.GetTestDescriptor(this, testType);
        }

        public TestResult Standerdization(TestTypeEnum testType, (int Years, int Months, int Days) age, short rawResult)
        {
            var lookupTable = this.GetStandardizerTableFor(age.Years, age.Months, age.Days);
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
            var standardResult = lookupTable.GetLabyrinthStandardizedResult(rawResult);
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
