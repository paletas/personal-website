using System.Collections.Generic;

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
            this.SupportedAgeIntervals = testStandardizer.SupportedAgeIntervals;
        }

        public bool Mandatory { get; }

        public IEnumerable<(Age From, Age To)> SupportedAgeIntervals { get; }

        public (short Min, short? Max) GetBoundaries(Age subjectAge)
        {
            var descriptorBySubject = this._testStandardizer.GetTestDescriptorPerAge(this._testType, subjectAge);
            return descriptorBySubject.Boundaries;
        }
    }
}
