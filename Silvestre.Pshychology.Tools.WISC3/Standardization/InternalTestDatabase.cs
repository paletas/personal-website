using Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers;
using System;

namespace Silvestre.Pshychology.Tools.WISC3.Tests
{
    internal static class InternalTestDatabase
    {
        public static TestDescriptor GetTestDescriptor(ITestStandardizer testStandardizer, TestTypeEnum testType)
        {
            return testType switch
            {
                TestTypeEnum.Information => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.Similarities => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.Arithmetic => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.Vocabulary => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.Comprehension => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.DigitMemory => new TestDescriptor(testStandardizer, testType, mandatory: false),
                TestTypeEnum.ImageCompletion => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.Code => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.ImageDisposition => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.Cubes => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.ObjectComposition => new TestDescriptor(testStandardizer, testType, mandatory: true),
                TestTypeEnum.SymbolSearch => new TestDescriptor(testStandardizer, testType, mandatory: false),
                TestTypeEnum.Labyrinth => new TestDescriptor(testStandardizer, testType, mandatory: false),
                _ => throw new NotImplementedException(),
            };
        }

        public static TestDescriptorPerAge GetTestDescriptorPerAge(IStandardizerLookupTable lookupTable, TestTypeEnum testType)
        {
            return testType switch
            {
                TestTypeEnum.Information => lookupTable.GetInformationDescriptor(),
                TestTypeEnum.Similarities => lookupTable.GetSimilaritiesDescriptor(),
                TestTypeEnum.Arithmetic => lookupTable.GetArithmeticDescriptor(),
                TestTypeEnum.Vocabulary => lookupTable.GetVocabularyDescriptor(),
                TestTypeEnum.Comprehension => lookupTable.GetComprehensionDescriptor(),
                TestTypeEnum.DigitMemory => lookupTable.GetDigitMemoryDescriptor(),
                TestTypeEnum.ImageCompletion => lookupTable.GetImageCompletionDescriptor(),
                TestTypeEnum.Code => lookupTable.GetCodeDescriptor(),
                TestTypeEnum.ImageDisposition => lookupTable.GetImageDispositionDescriptor(),
                TestTypeEnum.Cubes => lookupTable.GetCubesDescriptor(),
                TestTypeEnum.ObjectComposition => lookupTable.GetObjectCompositionDescriptor(),
                TestTypeEnum.SymbolSearch => lookupTable.GetSymbolSearchDescriptor(),
                TestTypeEnum.Labyrinth => lookupTable.GetLabyrinthDescriptor(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
