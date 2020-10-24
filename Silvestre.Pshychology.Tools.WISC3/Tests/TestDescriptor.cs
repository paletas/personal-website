namespace Silvestre.Pshychology.Tools.WISC3
{
    public class TestDescriptor
    {
        private readonly ITestStandardizer _testStandardizer;
        private readonly TestTypeEnum _testType;

        internal TestDescriptor(ITestStandardizer testStandardizer, TestTypeEnum testType, bool mandatory)
        {
            this._testStandardizer = testStandardizer;
            this._testType = testType;
            this.Mandatory = mandatory;
        }

        public bool Mandatory { get; }

        public (short Min, short? Max) GetBoundaries((int, int, int) subjectAge)
        {
            var descriptorBySubject = this._testStandardizer.GetTestDescriptorPerAge(this._testType, subjectAge);
            return descriptorBySubject.Boundaries;
        }
    }
}
