using System.Text.Json.Serialization;

namespace Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3.Charts
{
    public class WISC3StandardResultsChartViewModel
    {
        public WISC3StandardResultsChartViewModel(WISC3ViewModel viewModel)
        {
            this.Labels = new string[] { "Inf", "Sem", "Ari", "Voc", "Com", "MD", "CG", "Cd", "DG", "Cb", "CO", "PS", "Lb" };

            this.Verbal = new short?[]
            {
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_INFORMATION].StandardVerbal,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_SIMILARITIES].StandardVerbal,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_ARITHMETIC].StandardVerbal,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_VOCABULARY].StandardVerbal,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_COMPREHENSION].StandardVerbal,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_DIGITMEMORY].StandardVerbal,
                null, null, null, null, null, null, null
            };

            this.Realization = new short?[]
            {
                null, null, null, null, null, null,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_IMAGECOMPLETION].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_CODE].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_IMAGEDISPOSITION].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_CUBES].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_OBJECTCOMPOSITION].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_SYMBOLSEARCH].StandardRealization,
                viewModel.StanderdizationPhase[WISC3ViewModel.TEST_LABYRINTH].StandardRealization
            };
        }

        [JsonPropertyName("Labels")]
        public string[] Labels { get; }

        [JsonPropertyName("Verbal")]
        public short?[] Verbal { get; set; }

        [JsonPropertyName("Realization")]
        public short?[] Realization { get; set; }
    }
}
