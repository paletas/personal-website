namespace Silvestre.Pshychology.Tools.WISC3
{
    public struct Age : System.IComparable<Age>, System.IEquatable<Age>
    {
        public Age(int years, int months, int days)
        {
            this.Years = years;
            this.Months = months;
            this.Days = days;
        }

        public int Years { get; set; }

        public int Months { get; set; }

        public int Days { get; set; }

        public int CompareTo(Age other)
        {
            return (this.Years - other.Years) * 1000 + (this.Months - other.Months) * 100 + (this.Days - other.Days);
        }

        public bool Equals(Age other)
        {
            return other.Years == this.Years && other.Months == this.Months && other.Days == this.Days;
        }
    }
}
