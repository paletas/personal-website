using System.Text.Json.Serialization;

namespace Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3.Charts
{
    public class WISC3StandardFactorialIndicesChartViewModel
    {
        public WISC3StandardFactorialIndicesChartViewModel(WISC3ViewModel viewModel)
        {
            this.Labels = new string[] { "Inf", "Sem", "Voc", "Com", "CG", "DG", "Cb", "CO", "Cd", "PS" };

            this.VerbalComprehension = new short?[]
            {
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_INFORMATION].StandardVerbalComprehension,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_SIMILARITIES].StandardVerbalComprehension,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_VOCABULARY].StandardVerbalComprehension,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_COMPREHENSION].StandardVerbalComprehension,
                null, null, null, null, null, null, null, null, null
            };

            this.PerceptiveOrganization = new short?[]
            {
                null, null, null, null,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_IMAGECOMPLETION].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_IMAGEDISPOSITION].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_CUBES].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_OBJECTCOMPOSITION].StandardRealization,
                null, null
            };

            this.ProcessingVelocity = new short?[]
            {
                null, null, null, null, null, null, null, null,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_CODE].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_SYMBOLSEARCH].StandardRealization
            };
        }

        [JsonPropertyName("Labels")]
        public string[] Labels { get; }

        [JsonPropertyName("VerbalComprehension")]
        public short?[] VerbalComprehension { get; set; }

        [JsonPropertyName("PerceptiveOrganization")]
        public short?[] PerceptiveOrganization { get; set; }

        [JsonPropertyName("ProcessingVelocity")]
        public short?[] ProcessingVelocity { get; set; }
    }
}
