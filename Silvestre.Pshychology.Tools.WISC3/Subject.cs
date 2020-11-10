namespace Silvestre.Pshychology.Tools.WISC3
{
    public class Subject
    {
        public Subject(Age age, short verbalStandard, short realizationStandard, short completeStandard, short verbalComprehensionStandard, short perceptionOrganizationStandard, short processingVelocityStandard)
        {
            this.Age = age;
            this.VerbalStandard = verbalStandard;
            this.RealizationStandard = realizationStandard;
            this.CompleteStandard = completeStandard;
            this.VerbalComprehensionStandard = verbalComprehensionStandard;
            this.PerceptionOrganizationStandard = perceptionOrganizationStandard;
            this.ProcessingVelocityStandard = processingVelocityStandard;
        }

        public Age Age { get; }

        public short VerbalStandard { get; }

        public short RealizationStandard { get; }

        public short CompleteStandard { get; }

        public short VerbalComprehensionStandard { get; }

        public short PerceptionOrganizationStandard { get; }

        public short ProcessingVelocityStandard { get; }
    }
}
