using System;

namespace SimpleFraction
{
    public struct SimpleFraction : IComparable
    {
        public long Numerator { get; private set; }
        public long Denominator { get; private set; }

        public SimpleFraction(long x, long y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("The denominator cannot be zero");
            }

            Numerator = x;
            Denominator = y;

            ReduceFraction();
        }

        private long GCD(long x, long y)
        {
            return y == 0 ? x : GCD(y, x % y);
        }

        private void ReduceFraction()
        {
            var gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        public override string ToString()
        {
            var sign = (double)Numerator/Denominator > 0 ? "" : "-";
            return $"{sign}{Math.Abs(Numerator)}/{Math.Abs(Denominator)}";
        }

        public int CompareTo(object obj)
        {
            var fraction = (SimpleFraction) obj;

            return (Numerator * fraction.Denominator) > (fraction.Numerator * Denominator) ? 1 : (Numerator * fraction.Denominator) < (fraction.Numerator * Denominator) ? -1 : 0;
        }

        public static SimpleFraction operator +(SimpleFraction f1, SimpleFraction f2)
        {
            return new SimpleFraction(f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
        }

        public static SimpleFraction operator -(SimpleFraction f1, SimpleFraction f2)
        {
            return new SimpleFraction(f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
        }

        public static SimpleFraction operator *(SimpleFraction f1, SimpleFraction f2)
        {
            return new SimpleFraction(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator);
        }

        public static SimpleFraction operator /(SimpleFraction f1, SimpleFraction f2)
        {
            return new SimpleFraction(f1.Numerator * f2.Denominator, f1.Denominator * f2.Numerator);
        }
    }
}
