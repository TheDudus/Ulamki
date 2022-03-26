using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ulamki
{
    class Fraction:IComparable<Fraction>
    {
        int denominator;
        int meter;
        public Fraction(int meter, int denominator)
        {
            if (denominator == 0)
            {
                throw new Exception("Nie można dzielić przez 0!!!");
            }

            this.denominator = denominator;
            this.meter = meter;
        }
        public override string ToString()
        {
            return $"{meter}/{denominator}";
        }

        public Fraction add(Fraction secondFraction)
        {
            return new Fraction(meter * secondFraction.denominator + secondFraction.meter * denominator, denominator * secondFraction.denominator);
        }

        public int CompareTo(Fraction fr2)
        {
            int num1 = meter * fr2.denominator;
            int num2 = fr2.meter * denominator;

            if(num1>num2)
            {
                return 1;

            }
            else if(num1<num2)
            {
                return -1;
            }
            return 0;
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.meter * fr2.denominator + fr2.meter * fr1.denominator, fr1.denominator * fr2.denominator);
        }
        public static Fraction operator -(Fraction fr1)
        {
            return new Fraction(-fr1.meter, fr1.denominator);
        }
        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.meter * fr2.denominator, fr1.denominator * fr2.meter);
        }

    }
}
