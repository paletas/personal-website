using Microsoft.Extensions.Localization;
using Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3.Charts;
using Silvestre.Pshychology.Tools.WISC3;
using Silvestre.Pshychology.Tools.WISC3.Calculator;
using System;
using System.Linq;

namespace Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3
{
    public class WISC3ViewModel
    {
        private readonly WISC3CalculatedQIViewModel _verbal, _realization, _completeScale, _verbalComprehension, _perceptiveOrganization, _processingVelocity;
        private readonly IStringLocalizer _localizationServices;
        private Age? subjectAge;

        public const string CATEGORY_VERBAL = "Verbal", CATEGORY_REALIZATION = "Realization";
        public const string TEST_IMAGECOMPLETION = "ImageCompletion";
        public const string TEST_INFORMATION = "Information";
        public const string TEST_CODE = "Code";
        public const string TEST_SIMILARITIES = "Similarities";
        public const string TEST_IMAGEDISPOSITION = "ImageDisposition";
        public const string TEST_ARITHMETIC = "Arithmetic";
        public const string TEST_CUBES = "Cubes";
        public const string TEST_VOCABULARY = "Vocabulary";
        public const string TEST_OBJECTCOMPOSITION = "ObjectComposition";
        public const string TEST_COMPREHENSION = "Comprehension";
        public const string TEST_SYMBOLSEARCH = "SymbolSearch";
        public const string TEST_DIGITMEMORY = "DigitMemory";
        public const string TEST_LABYRINTH = "Labyrinth";
        public const string QI_VERBAL = "Verbal";
        public const string QI_REALIZATION = "Realization";
        public const string QI_COMPLETESCALE = "CompleteScale";
        public const string QI_VERBALCOMPREHENSION = "VerbalComprehension";
        public const string QI_PERCEPTIVEORGANIZATION = "PerceptiveOrganization";
        public const string QI_PROCESSINGVELOCITY = "ProcessingVelocity";

        public WISC3ViewModel(IStringLocalizer localizationServices, ITestStandardizer standardizer, IQICalculator calculator)
        {
            this._localizationServices = localizationServices;

            this.StanderdizationPhase = new WISC3StanderdizationViewModel
            (   standardizer,
                new WISC3TestViewModel(TEST_IMAGECOMPLETION, CATEGORY_REALIZATION, standardizer, TestTypeEnum.ImageCompletion),
                new WISC3TestViewModel(TEST_INFORMATION, CATEGORY_VERBAL, standardizer, TestTypeEnum.Information),
                new WISC3TestViewModel(TEST_CODE, CATEGORY_REALIZATION, standardizer, TestTypeEnum.Code),
                new WISC3TestViewModel(TEST_SIMILARITIES, CATEGORY_VERBAL, standardizer, TestTypeEnum.Similarities),
                new WISC3TestViewModel(TEST_IMAGEDISPOSITION, CATEGORY_REALIZATION, standardizer, TestTypeEnum.ImageDisposition),
                new WISC3TestViewModel(TEST_ARITHMETIC, CATEGORY_VERBAL, standardizer, TestTypeEnum.Arithmetic),
                new WISC3TestViewModel(TEST_CUBES, CATEGORY_REALIZATION, standardizer, TestTypeEnum.Cubes),
                new WISC3TestViewModel(TEST_VOCABULARY, CATEGORY_VERBAL, standardizer, TestTypeEnum.Vocabulary),
                new WISC3TestViewModel(TEST_OBJECTCOMPOSITION, CATEGORY_REALIZATION, standardizer, TestTypeEnum.ObjectComposition),
                new WISC3TestViewModel(TEST_COMPREHENSION, CATEGORY_VERBAL, standardizer, TestTypeEnum.Comprehension),
                new WISC3TestViewModel(TEST_SYMBOLSEARCH, CATEGORY_REALIZATION, standardizer, TestTypeEnum.SymbolSearch),
                new WISC3TestViewModel(TEST_DIGITMEMORY, CATEGORY_VERBAL, standardizer, TestTypeEnum.DigitMemory),
                new WISC3TestViewModel(TEST_LABYRINTH, CATEGORY_REALIZATION, standardizer, TestTypeEnum.Labyrinth)
            );

            this.CalculatorPhase = new WISC3CalculatorViewModel
            (
                _verbal = new WISC3CalculatedQIViewModel(QI_VERBAL, standardResult => calculator.CalculateVerbalQI(standardResult)),
                _realization = new WISC3CalculatedQIViewModel(QI_REALIZATION, standardResult => calculator.CalculateRealizationQI(standardResult)),
                _completeScale = new WISC3CalculatedQIViewModel(QI_COMPLETESCALE, standardResult => calculator.CalculateCompleteScaleQI(standardResult)),
                _verbalComprehension = new WISC3CalculatedQIViewModel(QI_VERBALCOMPREHENSION, standardResult => calculator.CalculateVerbalComprehensionQI(standardResult)),
                _perceptiveOrganization = new WISC3CalculatedQIViewModel(QI_PERCEPTIVEORGANIZATION, standardResult => calculator.CalculatePerceptiveOrganizationQI(standardResult)),
                _processingVelocity = new WISC3CalculatedQIViewModel(QI_PROCESSINGVELOCITY, standardResult => calculator.CalculateProcessingVelocityQI(standardResult))
            );

            this.StanderdizationPhase.OnStandardResultsUpdated += UpdateCalculatorResults;
            this.StanderdizationPhase.OnStandardResultsUpdated += (sender, args) => this.OnStandardResultsUpdated?.Invoke(this, args);
        }

        public Age? SubjectAge
        {
            get => subjectAge;
            set
            {
                subjectAge = value;
                OnSubjectAgeUpdated();
            }
        }

        public WISC3StanderdizationViewModel StanderdizationPhase { get; }

        public WISC3CalculatorViewModel CalculatorPhase { get; }

        public bool ShouldShowCharts { get; private set; }

        public event EventHandler? OnStandardResultsUpdated;

        public WISC3StandardResultsChartViewModel GetStandardResultsChartData()
        {
            return new WISC3StandardResultsChartViewModel(this);
        }

        public WISC3StandardFactorialIndicesChartViewModel GetStandardFactorialIndicesChartData()
        {
            return new WISC3StandardFactorialIndicesChartViewModel(this);
        }

        public WISC3QiIndicesChartViewModel GetQiIndicesChartData()
        {
            return new WISC3QiIndicesChartViewModel(this._localizationServices, this._verbal, this._realization, this._completeScale, this._verbalComprehension, this._perceptiveOrganization, this._processingVelocity);
        }

        private void OnSubjectAgeUpdated()
        {
            this.StanderdizationPhase.SetSubjectAge(this.SubjectAge);
        }

        private void UpdateCalculatorResults(object sender, EventArgs args)
        {
            if (AreAllMandatoryTestComplete())
            {
                this._verbal.StandardResult = this.StanderdizationPhase.VerbalTotal;
                this._realization.StandardResult = this.StanderdizationPhase.RealizationTotal;
                this._completeScale.StandardResult = (short)(this.StanderdizationPhase.VerbalTotal + this.StanderdizationPhase.RealizationTotal);
                this._verbalComprehension.StandardResult = this.StanderdizationPhase.VerbalComprehensionTotal;
                this._perceptiveOrganization.StandardResult = this.StanderdizationPhase.PerceptiveOrganizationTotal;
                this._processingVelocity.StandardResult = this.StanderdizationPhase.ProcessingVelocityTotal;

                this.ShouldShowCharts = true;
            }
            else
            {
                this._verbal.StandardResult = null;
                this._realization.StandardResult = null;
                this._completeScale.StandardResult = null;
                this._verbalComprehension.StandardResult = null;
                this._perceptiveOrganization.StandardResult = null;
                this._processingVelocity.StandardResult = null;

                this.ShouldShowCharts = false;
            }
        }

        private bool AreAllMandatoryTestComplete()
        {
            return this.StanderdizationPhase.AllTests.Where(t => t.Mandatory).All(t => t.RawResult != null);
        }
    }
}
