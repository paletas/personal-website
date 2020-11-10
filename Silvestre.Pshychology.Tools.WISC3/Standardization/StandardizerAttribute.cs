using System;

namespace Silvestre.Pshychology.Tools.WISC3.Standardization
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class StandardizerAttribute : Attribute
    {
        public StandardizerAttribute(string country)
        {
            this.Country = country;
        }

        public string Country { get; }
    }
}
