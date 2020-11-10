using Silvestre.Pshychology.Tools.WISC3;
using System;

namespace Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3
{
    public class WISC3TestViewModel
    {
        private readonly ITestStandardizer _testStandardizer;
        private readonly TestTypeEnum _testType;
        private readonly TestDescriptor _testDescriptor;
        private TestDescriptorPerAge? _testDescriptorPerAge;
        private Age? _subjectAge;
        private short? _rawResult;

        public WISC3TestViewModel(string testName, string category, ITestStandardizer testStandardizer, TestTypeEnum testType)
        {
            this._testStandardizer = testStandardizer;
            this._testType = testType;
            this._testDescriptor = this._testStandardizer.GetTestDescriptor(this._testType);

            this.TestCategory = category;
            this.TestName = testName;
        }

        public event EventHandler? OnStandardResultsUpdated;

        public string TestCategory { get; }

        public string TestName { get; }

        public bool Mandatory => this._testDescriptor.Mandatory;

        public Age? SubjectAge
        {
            get => this._subjectAge;
            set
            {
                this._subjectAge = value;

                if (this._subjectAge == null) this._testDescriptorPerAge = null;
                else this._testDescriptorPerAge = this._testStandardizer.GetTestDescriptorPerAge(this._testType, this._subjectAge.Value);

                UpdateStandardResults();
            }
        }

        public short? RawResult
        {
            get => this._rawResult;
            set
            {
                this._rawResult = value;
                UpdateStandardResults();
            }
        }

        public short? StandardVerbal { get; private set; }

        public short? StandardRealization { get; private set; }

        public short? StandardVerbalComprehension { get; private set; }

        public short? StandardPerceptiveOrganization { get; private set; }

        public short? StandardProcessingVelocity { get; private set; }

        public (short MinValue, short? MaxValue)? GetRawResultBoundaries()
        {
            return this._testDescriptorPerAge?.Boundaries;
        }

        internal void UpdateStandardResults()
        {
            if (this.SubjectAge != null && this.RawResult != null)
            {
                var results = this._testStandardizer.Standerdization(this._testType, this.SubjectAge.Value, this.RawResult.Value);

                this.StandardVerbal = results.Verbal;
                this.StandardRealization = results.Realization;
                this.StandardVerbalComprehension = results.VerbalComprehension;
                this.StandardPerceptiveOrganization = results.PerceptiveOrganization;
                this.StandardProcessingVelocity = results.ProcessingVelocity;
            }
            else
            {
                this.StandardVerbal = null;
                this.StandardRealization = null;
                this.StandardVerbalComprehension = null;
                this.StandardPerceptiveOrganization = null;
                this.StandardProcessingVelocity = null;
            }

            this.OnStandardResultsUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
