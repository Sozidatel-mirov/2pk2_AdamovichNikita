using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_2._5
{
    class FractionalNumber
    {
        char sign = '-';
        int dividend;
        int divider;
        static int Counter1 = 0;
        static int Counter2 = 0;
        public char Sign
        {
            get { return sign; }
            set { sign = value; }
        }
        public int Dividend
        {
            get { return dividend; }
            set { dividend = value; }

        }
        public int Divider
        {
            get { return divider; }
            set { if (value == 0) divider = 999; else divider = value; }
        }

        public FractionalNumber(int n = 1, int b = 1)
        {
            Dividend = n;
            Divider = b;
            Counter1++;
        }
        public FractionalNumber(char a = '+', int n = 1, int b = 1)
        {
            Sign = a;
            Dividend = n;
            Divider = b;
            if (sign == '+') Counter1++;
            else Counter2++;
        }
        public FractionalNumber(int n = 1)
        {
            Dividend = n;
            Counter1++;
        }
        public FractionalNumber(char a = '+', int n = 1)
        {
            Sign = a;
            Dividend = n;
            if (sign == '+') Counter1++;
            else Counter2++;
        }
        public static int GetCounter()
        { return Counter1; }
        public static int GetCounter2()
        { return Counter2; }
        public virtual void Print()
        {
            if (divider != 0)
            {
                Console.WriteLine("Вы ввели число: " + Sign + dividend + "/" + Divider);
            }
            else
                Console.WriteLine("Вы ввели число: " + sign + dividend);

        }
    }
}
