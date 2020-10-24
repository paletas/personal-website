using Silvestre.Pshychology.Tools.WISC3.Calculator;
using Silvestre.Pshychology.Tools.WISC3.Calculator.ConvertionScales.Portugal;
using Silvestre.Pshychology.Tools.WISC3.Standardization.Standardizers.Portugal;
using System;
using System.Collections.Generic;

namespace Silvestre.Pshychology.Tools.WISC3
{
    public static class WISC3Test
    {
        private static readonly IDictionary<string, ITestStandardizer> _Standerdizers = new Dictionary<string, ITestStandardizer>
        {
            { SupportedCountries.Portugal, new PortugalStandardizer() }
        };

        private static readonly IDictionary<string, IQICalculator> _Calculators = new Dictionary<string, IQICalculator>
        {
            { SupportedCountries.Portugal, new PortugalCalculator() }
        };

        public static ITestStandardizer Standerdization(string country)
        {
            if (_Standerdizers.ContainsKey(country) == false) throw new ArgumentOutOfRangeException(nameof(country), country, "Country not supported");

            return _Standerdizers[country];
        }

        public static IQICalculator QICalculator(string country)
        {
            if (_Calculators.ContainsKey(country) == false) throw new ArgumentOutOfRangeException(nameof(country), country, "Country not supported");

            return _Calculators[country];
        }
    }
}
