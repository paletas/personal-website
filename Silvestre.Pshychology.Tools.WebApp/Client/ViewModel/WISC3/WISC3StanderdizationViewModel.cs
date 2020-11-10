using Silvestre.Pshychology.Tools.WISC3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3
{
    public class WISC3StanderdizationViewModel
    {
        public WISC3StanderdizationViewModel(ITestStandardizer standardizer, params WISC3TestViewModel[] tests)
        {
            Standardizer = standardizer;
            AllTests = tests;

            foreach (var test in this.AllTests)
                test.OnStandardResultsUpdated += (sender, args) => OnStandardResultsUpdated?.Invoke(this, EventArgs.Empty);
        }

        public WISC3TestViewModel this[string testName]
        {
            get { return AllTests.Single(test => test.TestName == testName); }
        }

        public ITestStandardizer Standardizer { get; }

        public IEnumerable<WISC3TestViewModel> AllTests { get; set; }

        public short VerbalTotal { get { return (short)this.AllTests.Sum(tr => tr.StandardVerbal ?? 0); } }

        public short RealizationTotal { get { return (short)this.AllTests.Sum(tr => tr.StandardRealization ?? 0); } }

        public short VerbalComprehensionTotal { get { return (short)this.AllTests.Sum(tr => tr.StandardVerbalComprehension ?? 0); } }

        public short PerceptiveOrganizationTotal { get { return (short)this.AllTests.Sum(tr => tr.StandardPerceptiveOrganization ?? 0); } }

        public short ProcessingVelocityTotal { get { return (short)this.AllTests.Sum(tr => tr.StandardProcessingVelocity ?? 0); } }

        public void SetSubjectAge(Age? subjectAge)
        {
            foreach (var test in this.AllTests) test.SubjectAge = subjectAge;

            OnStandardResultsUpdated?.Invoke(this, EventArgs.Empty);
        }

        public EventHandler? OnStandardResultsUpdated;
    }
}
