using System.Collections.Generic;

namespace Silvestre.Pshychology.Tools.WISC3
{
    public interface ITestStandardizer
    {
        IEnumerable<(Age From, Age To)> SupportedAgeIntervals { get; }

        TestDescriptor GetTestDescriptor(TestTypeEnum testType);

        IEnumerable<TestDescriptorPerAge> GetTestDescriptorsPerType(TestTypeEnum testType);

        TestDescriptorPerAge GetTestDescriptorPerAge(TestTypeEnum testType, Age age);

        TestResult Standerdization(TestTypeEnum testType, Age age, short rawResult);
    }
}
