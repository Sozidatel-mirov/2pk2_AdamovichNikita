using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[10];
            Random rnd = new Random();
            int y = 0;
            for (int j = 0; j < 10; j++)
            {
                i[j] = rnd.Next(10);
                Console.Write(i[j] + " ");
            }

            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if(k!=j && i[j] > i[k])
                    {
                        y = i[j];
                    }
                }
            }
            Console.WriteLine(y);
        }
    }
}
