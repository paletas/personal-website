using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3;
using Silvestre.Pshychology.Tools.WISC3;
using System;
using System.Collections.Generic;

namespace Silvestre.Pshychology.Tools.WebApp.Client.Pages
{
    public partial class WISC3 : ComponentBase
    {
        protected override void OnInitialized()
        {
            var standerdizer = WISC3Test.Standerdization(SupportedCountries.Portugal);
            var calculator = WISC3Test.QICalculator(SupportedCountries.Portugal);

            this.WISC3ViewModel = new WISC3ViewModel(this.LocalizationService, standerdizer, calculator);
            this.WISC3ViewModel.OnStandardResultsUpdated += WISC3ViewModel_OnStandardResultsUpdated;

#if DEBUG
            this.SubjectBirthday = new DateTime(2014, 09, 20);
            this.TestDate = new DateTime(2020, 09, 30);
            TestOrSubjectDatesUpdated(new KeyboardEventArgs());

            var rng = new Random();
            foreach (var test in this.WISC3ViewModel.StanderdizationPhase.AllTests)
            {
                var boundaries = test.GetRawResultBoundaries();
                test.RawResult = (short)rng.Next(boundaries?.MinValue ?? 1, boundaries?.MaxValue ?? 1);
            }
#endif
        }

        [Inject]
        protected IJSRuntime JsRuntime { get; set; }

        [Inject]
        protected IStringLocalizer<WISC3> LocalizationService { get; set; }

        public bool IsInitialInputValid { get; set; }

        public DateTime? SubjectBirthday { get; set; }

        public DateTime? TestDate { get; set; }

        public WISC3ViewModel? WISC3ViewModel { get; private set; }

        public ElementReference StandardResultsChart { get; private set; }

        public ElementReference StandardFactorialIndicesChart { get; private set; }

        public ElementReference QIResultsChart { get; private set; }

        protected void TestOrSubjectDatesUpdated(KeyboardEventArgs args)
        {
            if (this.WISC3ViewModel == null) throw new ArgumentNullException(nameof(WISC3ViewModel));

            if (SubjectBirthday == null || TestDate == null)
                this.WISC3ViewModel.SubjectAge = null;
            else
            {
                var subjectAge = new Age(TestDate.Value.Year - SubjectBirthday.Value.Year, TestDate.Value.Month - SubjectBirthday.Value.Month, TestDate.Value.Day - SubjectBirthday.Value.Day);
                this.IsInitialInputValid = true;
                this.WISC3ViewModel.SubjectAge = subjectAge;
            }
        }

        private void WISC3ViewModel_OnStandardResultsUpdated(object sender, EventArgs e)
        {
            if (this.WISC3ViewModel != null && this.WISC3ViewModel.ShouldShowCharts)
            {
                this.JsRuntime.InvokeVoidAsync("wisc3.drawStandardResultsChart", this.StandardResultsChart, this.WISC3ViewModel.GetStandardResultsChartData());
                this.JsRuntime.InvokeVoidAsync("wisc3.drawStandardFactorialIndicesChart", this.StandardFactorialIndicesChart, this.WISC3ViewModel.GetStandardFactorialIndicesChartData());
                this.JsRuntime.InvokeVoidAsync("wisc3.drawQiResultsChart", this.QIResultsChart, this.WISC3ViewModel.GetQiIndicesChartData());
            }
        }

        private IDictionary<string, object>? GetTestResultAttributes(short? rawResult, short? standardizedResult)
        {
            if (rawResult != null && standardizedResult != null) return null;
            else
            {
                IDictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "class", "bg-dark" }
                };

                return parameters;
            }
        }
    }
}
