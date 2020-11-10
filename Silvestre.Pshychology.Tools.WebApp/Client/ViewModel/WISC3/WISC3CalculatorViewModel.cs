using System.Collections.Generic;

namespace Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3
{
    public class WISC3CalculatorViewModel
    {
        public WISC3CalculatorViewModel(params WISC3CalculatedQIViewModel[] calculatedQI)
        {
            this.AllCalculatedQI = calculatedQI;
        }

        public IEnumerable<WISC3CalculatedQIViewModel> AllCalculatedQI { get; }
    }
}
