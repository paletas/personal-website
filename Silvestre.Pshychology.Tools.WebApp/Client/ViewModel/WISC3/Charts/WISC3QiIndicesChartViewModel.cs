using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3.Charts
{
    public class WISC3QiIndicesChartViewModel
    {
        public class BoxPlotEntryViewModel
        {
            [JsonPropertyName("label")]
            public string Name { get; set; }

            [JsonPropertyName("min")]
            public short? Min { get; set; }

            [JsonPropertyName("max")]
            public short? Max { get; set; }

            [JsonPropertyName("q1")]
            public short? Q1 { get; set; }

            [JsonPropertyName("q3")]
            public short? Q3 { get; set; }

            [JsonPropertyName("median")]
            public short? Median { get; set; }
        }

        public WISC3QiIndicesChartViewModel(IStringLocalizer localizationServices, WISC3CalculatedQIViewModel verbalQI, WISC3CalculatedQIViewModel realizationQI, WISC3CalculatedQIViewModel completeScaleQI, WISC3CalculatedQIViewModel verbalComprehensionIndex, WISC3CalculatedQIViewModel perceptiveOrganizationIndex, WISC3CalculatedQIViewModel processingVelocityIndex)
        {
            this.QI = new[]
            {
                new BoxPlotEntryViewModel
                {
                    Name = localizationServices[$"QI.{verbalQI.Name}"],
                    Min = verbalQI.ConfidenceInterval95?.LowerBound,
                    Max = verbalQI.ConfidenceInterval95?.UpperBound,
                    Q1 = verbalQI.ConfidenceInterval90?.LowerBound,
                    Q3 = verbalQI.ConfidenceInterval90?.UpperBound,
                    Median = verbalQI.IndexQI
                },
                new BoxPlotEntryViewModel
                {
                    Name = localizationServices[$"QI.{realizationQI.Name}"],
                    Min = realizationQI.ConfidenceInterval95?.LowerBound,
                    Max = realizationQI.ConfidenceInterval95?.UpperBound,
                    Q1 = realizationQI.ConfidenceInterval90?.LowerBound,
                    Q3 = realizationQI.ConfidenceInterval90?.UpperBound,
                    Median = realizationQI.IndexQI
                },
                new BoxPlotEntryViewModel
                {
                    Name = localizationServices[$"QI.{completeScaleQI.Name}"],
                    Min = completeScaleQI.ConfidenceInterval95?.LowerBound,
                    Max = completeScaleQI.ConfidenceInterval95?.UpperBound,
                    Q1 = completeScaleQI.ConfidenceInterval90?.LowerBound,
                    Q3 = completeScaleQI.ConfidenceInterval90?.UpperBound,
                    Median = completeScaleQI.IndexQI
                }
            };

            this.Indices = new[]
            {
                new BoxPlotEntryViewModel
                {
                    Name = localizationServices[$"QI.{verbalComprehensionIndex.Name}"],
                    Min = verbalComprehensionIndex.ConfidenceInterval95?.LowerBound,
                    Max = verbalComprehensionIndex.ConfidenceInterval95?.UpperBound,
                    Q1 = verbalComprehensionIndex.ConfidenceInterval90?.LowerBound,
                    Q3 = verbalComprehensionIndex.ConfidenceInterval90?.UpperBound,
                    Median = verbalComprehensionIndex.IndexQI
                },
                new BoxPlotEntryViewModel
                {
                    Name = localizationServices[$"QI.{perceptiveOrganizationIndex.Name}"],
                    Min = perceptiveOrganizationIndex.ConfidenceInterval95?.LowerBound,
                    Max = perceptiveOrganizationIndex.ConfidenceInterval95?.UpperBound,
                    Q1 = perceptiveOrganizationIndex.ConfidenceInterval90?.LowerBound,
                    Q3 = perceptiveOrganizationIndex.ConfidenceInterval90?.UpperBound,
                    Median = perceptiveOrganizationIndex.IndexQI
                },
                new BoxPlotEntryViewModel
                {
                    Name = localizationServices[$"QI.{processingVelocityIndex.Name}"],
                    Min = processingVelocityIndex.ConfidenceInterval95?.LowerBound,
                    Max = processingVelocityIndex.ConfidenceInterval95?.UpperBound,
                    Q1 = processingVelocityIndex.ConfidenceInterval90?.LowerBound,
                    Q3 = processingVelocityIndex.ConfidenceInterval90?.UpperBound,
                    Median = processingVelocityIndex.IndexQI
                }
            };
        }

        [JsonPropertyName("QI")]
        public IEnumerable<BoxPlotEntryViewModel> QI { get; set; }

        [JsonPropertyName("Indices")]
        public IEnumerable<BoxPlotEntryViewModel> Indices { get; set; }
    }
}
