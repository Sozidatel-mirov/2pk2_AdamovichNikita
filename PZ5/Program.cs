using System;

namespace PZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1");
            //ЗАДАНИЕ 1
            int a;//Вводим переменную
            for (a = 0; a < 101; a = a + 2)//а равно 0, а равно прошлое а плюс 2, пока а меньше ста выполнять:
            {
                Console.WriteLine(a);//вывести а
            }
            Console.WriteLine("задание 2");
            //ЗАДАНИЕ 2
            char simvol;
            int b = 1;
            for (simvol = 'a'; b<6; simvol++, b++)
            {
                Console.Write(simvol);
            }
            Console.WriteLine();
            Console.WriteLine("задание 3");
            //ЗАДАНИЕ 3
            int n, m;
            for(n=1;n<4;n++)
            {
                Console.WriteLine();
                for(m=1;m<6;m++)
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
            Console.WriteLine("задание 4");
            //ЗАДАНИЕ 4
            for (int c = 0; c<100; c += 3)
                {
                    Console.WriteLine(c);
                }
            Console.WriteLine("задание 5");
            //ЗАДАНИЕ 5
            for (int i = 1, j = 40; i - j < 10; i++, j--)
            {
                Console.WriteLine("Разница равна: " + (i - j));
            }

        }
    }
}
