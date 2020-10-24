using System;
using System.Collections.Generic;

namespace Silvestre.Pshychology.Tools.WISC3.Calculator.ConvertionScales
{
    internal abstract class ConvertionScaleByLookup : IConvertionScale
    {
        protected internal abstract IDictionary<short, (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95)> LookupTable { get; }

        public bool IsResultSupported(short results)
        {
            return LookupTable.ContainsKey(results) || OnResultOutOfBounds(results) != null;
        }

        public (short, short) ConfidenceIntervalBottomBoundary(short results, ConfidenceIntervalPercentageEnum percentage)
        {
            (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95) lookupEntry;
            if (LookupTable.ContainsKey(results))
                lookupEntry = LookupTable[results];
            else
            {
                var outEntry = OnResultOutOfBounds(results);
                if (outEntry == null) throw new InvalidOperationException();
                lookupEntry = outEntry.Value;
            }

            return percentage switch
            {
                ConfidenceIntervalPercentageEnum.Per90 => lookupEntry.Per90,
                ConfidenceIntervalPercentageEnum.Per95 => lookupEntry.Per95,
                _ => throw new NotImplementedException(),
            };
        }

        public decimal Percentil(short results)
        {
            (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95) lookupEntry;
            if (LookupTable.ContainsKey(results))
                lookupEntry = LookupTable[results];
            else
            {
                var outEntry = OnResultOutOfBounds(results);
                if (outEntry == null) throw new InvalidOperationException();
                lookupEntry = outEntry.Value;
            }

            return lookupEntry.Percentile;
        }

        public short QI(short results)
        {
            (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95) lookupEntry;
            if (LookupTable.ContainsKey(results))
                lookupEntry = LookupTable[results];
            else
            {
                var outEntry = OnResultOutOfBounds(results);
                if (outEntry == null) throw new InvalidOperationException();
                lookupEntry = outEntry.Value;
            }

            return lookupEntry.QI;
        }

        protected abstract (short QI, decimal Percentile, (short, short) Per90, (short, short) Per95)? OnResultOutOfBounds(short results);
    }
}
