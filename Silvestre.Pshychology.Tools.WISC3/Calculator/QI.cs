namespace Silvestre.Pshychology.Tools.WISC3.Calculator
{
    public class QI
    {
        public QI(short value, decimal percentil, (short, short) confidenceInterval90, (short, short) confidenceInterval95)
        {
            Value = value;
            Percentil = percentil;
            ConfidenceInterval90 = confidenceInterval90;
            ConfidenceInterval95 = confidenceInterval95;
        }

        public short Value { get; }

        public decimal Percentil { get; }

        public (short BottomBoundary, short TopBoundary) ConfidenceInterval90 { get; }

        public (short BottomBoundary, short TopBoundary) ConfidenceInterval95 { get; }
    }
}
