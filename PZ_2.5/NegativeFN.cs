using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_2._5
{
    class NegativeFN : FractionalNumber
    {
        public int Capacity { get; set; }
        public NegativeFN(char a = '+', int n = 1, int b = 1, int y = 1)
            : base(a, n, b)
        {
            Capacity = y;
            Sign = '-';
        }
        public override sealed void Print()
        {
                Console.WriteLine("Вы ввели число:  {0}{1:D3}/{2:D1}", Sign, Dividend.ToString("D" + Capacity.ToString()), Divider.ToString("D" + Capacity.ToString()));
        }
    }
}
