using Silvestre.Pshychology.Tools.WISC3.Calculator;
using System;

namespace Silvestre.Pshychology.Tools.WebApp.Client.ViewModel.WISC3
{
    public class WISC3CalculatedQIViewModel
    {
        private readonly Func<short, QI?> _calculateQI;
        private short? _standardResult;

        public WISC3CalculatedQIViewModel(string qiName, Func<short, QI?> calculateQI)
        {
            this._calculateQI = calculateQI;

            this.Name = qiName;
        }

        public string Name { get; }

        public short? StandardResult
        {
            get => _standardResult;
            set
            {
                _standardResult = value;
                CalculateQI();
            }
        }

        public short? IndexQI { get; private set; }

        public decimal? Percentil { get; private set; }

        public (short LowerBound, short UpperBound)? ConfidenceInterval90 { get; private set; }

        public (short LowerBound, short UpperBound)? ConfidenceInterval95 { get; private set; }

        private void CalculateQI()
        {
            if (this.StandardResult == null) return;

            var qi = _calculateQI(this.StandardResult.Value);

            this.IndexQI = qi?.Value;
            this.Percentil = qi?.Percentil;
            this.ConfidenceInterval90 = qi?.ConfidenceInterval90;
            this.ConfidenceInterval95 = qi?.ConfidenceInterval95;
        }
    }
}
