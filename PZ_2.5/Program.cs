using System;

namespace PZ_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            FractionalNumber number1 = new FractionalNumber('-', 3, 3);
            number1.Print();
            FractionalNumber number2 = new FractionalNumber(5, 4);
            number2.Print();
            FractionalNumber number3 = new FractionalNumber(2);
            number3.Print();
            FractionalNumber number4 = new FractionalNumber('+', 6);
            number4.Print();
            Console.WriteLine("Положительных Объектов: " + FractionalNumber.GetCounter());
            Console.WriteLine("Отрицательных Объектов: " + FractionalNumber.GetCounter2());
            NegativeFN b = new NegativeFN('=', 3, 3, 3);
            b.Print();
        }
    }
}
