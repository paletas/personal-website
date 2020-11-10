using System;
using System.Collections.Generic;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal
{
    [Standardizer(SupportedCountries.Portugal)]
    internal class PortugalStandardizer : LookupStandardizer
    {
        protected override IDictionary<(Age From, Age To), IStandardizerLookupTable> GetLookupTables()
        {
            return new Dictionary<(Age From, Age To), IStandardizerLookupTable>
            {
                { (new Age(6, 0, 0),   new Age(6, 5, 30)),   new SixYearLookupTable() },
                { (new Age(6, 5, 30),  new Age(6, 12, 30)),  new SixYearSixMonthLookupTable() },
                { (new Age(7, 0, 0),   new Age(7, 5, 30)),   new SevenYearLookupTable() },
                { (new Age(7, 5, 30),  new Age(7, 12, 30)),  new SevenYearSixMonthLookupTable() },
                { (new Age(8, 0, 0),   new Age(8, 5, 30)),   new EightYearMonthLookupTable() },
                { (new Age(8, 5, 30),  new Age(8, 12, 30)),  new EightYearSixMonthLookupTable() },
                { (new Age(9, 0, 0),   new Age(9, 5, 30)),   new NineYearLookupTable() },
                { (new Age(9, 5, 30),  new Age(9, 12, 30)),  new NineYearSixMonthLookupTable() },
                { (new Age(10, 0, 0),  new Age(10, 5, 30)),  new TenYearLookupTable() },
                { (new Age(10, 5, 30), new Age(10, 12, 30)), new TenYearSixMonthLookupTable() },
                { (new Age(11, 0, 0),  new Age(11, 5, 30)),  new ElevenYearLookupTable() },
                { (new Age(11, 5, 30), new Age(11, 12, 30)), new ElevenYearSixMonthLookupTable() },
                { (new Age(12, 0, 0),  new Age(12, 5, 30)),  new TwelveYearLookupTable() },
                { (new Age(12, 5, 30), new Age(12, 12, 30)), new TwelveYearSixMonthLookupTable() },
                { (new Age(13, 0, 0),  new Age(13, 5, 30)),  new ThirteenYearLookupTable() },
                { (new Age(13, 5, 30), new Age(13, 12, 30)), new ThirteenYearSixMonthLookupTable() },
                { (new Age(14, 0, 0),  new Age(14, 5, 30)),  new FourteenYearLookupTable() },
                { (new Age(14, 5, 30), new Age(14, 12, 30)), new FourteenYearSixMonthLookupTable() },
                { (new Age(15, 0, 0),  new Age(15, 5, 30)),  new FifteenYearLookupTable() },
                { (new Age(15, 5, 30), new Age(15, 12, 30)), new FifteenYearSixMonthLookupTable() },
                { (new Age(16, 0, 0),  new Age(16, 5, 30)),  new SixteenYearLookupTable() },
                { (new Age(16, 5, 30), new Age(16, 12, 30)), new SixteenYearSixMonthLookupTable() }
            };
        }
    }
}
