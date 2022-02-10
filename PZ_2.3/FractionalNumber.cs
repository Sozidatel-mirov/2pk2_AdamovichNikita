using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_2._3
{
    class FractionalNumber
    {
        public char sign;
        public int dividend;
        public int divider;

        public FractionalNumber(int n, int b)
        {
            dividend = n;
            divider = b;
        }
        public FractionalNumber(char a, int n, int b)
        {
            sign = a;
            dividend = n;
            divider = b;
        }
        public FractionalNumber(int n)
        {
            dividend = n;
        }
        public FractionalNumber(char a, int n)
        {
            sign = a;
            dividend = n;
        }

        public void Print()
        {
            if (divider != 0)
                Console.WriteLine("Вы ввели число: " + sign + dividend + "/" + divider);
            else
                Console.WriteLine("Вы ввели число: " + sign + dividend);
        }
    }
}
