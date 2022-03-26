using System;
using System.Collections.Generic;

namespace Ulamki
{
    class Compare : IComparer<Fraction>
    {
        int IComparer<Fraction>.Compare(Fraction fr1, Fraction fr2)
        {
            int num1 = meter * fr2.denominator;
            int num2 = fr2.meter * denominator;

            if (num1 > num2)
            {
                return 1;

            }
            else if (num1 < num2)
            {
                return -1;
            }
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(1,2);
            Fraction fr2 = new Fraction(8,2);
            Fraction fr3 = fr1.add(fr2);

            Console.WriteLine(fr3);
            Console.WriteLine(fr1 / fr2);

            List<Fraction> list = new List<Fraction>();
            list.Add(fr1);
            list.Add(fr2);
            list.Add(new Fraction(2, 7));
            list.Add(new Fraction(7, 10));
            list.Sort();

            list.ForEach(Console.WriteLine);
        }
    }
}
