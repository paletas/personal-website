namespace Silvestre.Pshychology.Tools.WISC3.Calculator.ConvertionScales
{
    public interface IConvertionScale
    {
        bool IsResultSupported(short results);

        short QI(short results);

        decimal Percentil(short results);

        (short Lower, short Upper) ConfidenceIntervalBottomBoundary(short results, ConfidenceIntervalPercentageEnum percentage);
    }

    public enum ConfidenceIntervalPercentageEnum
    {
        Per90,
        Per95
    }
}
