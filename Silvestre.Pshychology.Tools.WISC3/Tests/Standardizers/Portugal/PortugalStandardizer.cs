using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    [Standardizer(SupportedCountries.Portugal)]
    internal class PortugalStandardizer : LookupStandardizer
    {
        protected override IStandardizerLookupTable GetStandardizerTableFor(int years, int months, int days)
        {
            return (Years: years, Months: months, Days: days) switch
            {
                (int _, int _, int _) age when age.Years == 6 && age.Months <= 5 && age.Days <= 30 => new SixYearLookupTable(),
                _ => throw new ArgumentOutOfRangeException("age"),
            };
        }
    }
}
