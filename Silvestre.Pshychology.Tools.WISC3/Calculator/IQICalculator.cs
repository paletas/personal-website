namespace Silvestre.Pshychology.Tools.WISC3.Calculator
{
    public interface IQICalculator
    {
        QI? CalculateVerbalQI(short standardTestResults);

        QI? CalculateRealizationQI(short standardTestResults);

        QI? CalculateCompleteScaleQI(short standardTestResults);

        QI? CalculateVerbalComprehensionQI(short standardTestResults);

        QI? CalculatePerceptiveOrganizationQI(short standardTestResults);

        QI? CalculateProcessingVelocityQI(short standardTestResults);
    }
}
