using System;

namespace PZ_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            FractionalNumber number1 = new FractionalNumber( '-', 24, 25);
            number1.Print();
            FractionalNumber number2 = new FractionalNumber(24, 25);
            number2.Print();
            FractionalNumber number3 = new FractionalNumber(24);
            number3.Print();
            FractionalNumber number4 = new FractionalNumber( '+', 24);
            number4.Print();
        }
    }
}
