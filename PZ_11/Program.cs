using System;
namespace PZ_11
{
    internal class programm
    {
        unsafe static void Main(string[] args)
        {
            double val;//Создание переменной double
            byte* x = (byte*)&val; //указатель на знанчения типа double

            //запись значений в указатель

            x[0] = 1;
            x[1] = (byte)'A';
            x[2] = (byte)'A';
            x[3] = 2;
            x[4] = 2;
            x[5] = 2;
            x[6] = 2;
            x[7] = 3;
            //вывод значений 
            Console.WriteLine("Адрес\t\tЗначение");
            Console.WriteLine($"{(uint)&x[0]}\t{x[0]}");
            Console.WriteLine($"{(uint)&x[1]}\t{(char)x[1]}");
            Console.WriteLine($"{(uint)&x[2]}\t{(char)x[2]}");
            for (int i = 3; i < 8; i++)
            {
                Console.WriteLine($"{(uint)&x[i]}\t{x[i]}");
            }

        }
    }
}
