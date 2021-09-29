using System;

namespace PZ_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int n;
            n = int.Parse(Console.ReadLine());
            int k = 1;
            while (k*k < n)
            {
                Console.WriteLine(k * k);
                k++;
            }
        }
    }
}
