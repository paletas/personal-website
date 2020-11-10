namespace Silvestre.Pshychology.Tools.WISC3
{
    public class TestResult
    {
        internal TestResult(short? verbal, short? realization, short? verbalComprehension, short? perceptiveOrganization, short? processingVelocity)
        {
            Verbal = verbal;
            Realization = realization;
            VerbalComprehension = verbalComprehension;
            PerceptiveOrganization = perceptiveOrganization;
            ProcessingVelocity = processingVelocity;
        }

        public short? Verbal { get; }

        public short? Realization { get; }

        public short? VerbalComprehension { get; }

        public short? PerceptiveOrganization { get; }

        public short? ProcessingVelocity { get; }
    }
}
