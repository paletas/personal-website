namespace Silvestre.Pshychology.Tools.WISC3
{
    public class TestDescriptorPerAge
    {
        internal TestDescriptorPerAge((short Min, short? Max) boundaries)
        {
            this.Boundaries = boundaries;
        }

        public (short Min, short? Max) Boundaries { get; }
    }
}
