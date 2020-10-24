namespace Silvestre.Pshychology.Tools.WISC3
{
    public interface ITestStandardizer
    {
        TestDescriptor GetTestDescriptor(TestTypeEnum testType);

        TestDescriptorPerAge GetTestDescriptorPerAge(TestTypeEnum testType, (int Years, int Months, int Days) age);

        TestResult Standerdization(TestTypeEnum testType, (int Years, int Months, int Days) age, short rawResult);
    }
}
