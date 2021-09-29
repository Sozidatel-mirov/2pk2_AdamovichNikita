using System;

namespace PZ_5
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
            int b = 1;//Вводим переменную и символ
            for (simvol = 'a'; b < 6; simvol++, b++)//Пока b меньше шести, писать символ. а и b равны на еденицу больше их предыдущих значений
            {
                Console.Write(simvol);
            }
            Console.WriteLine();
            Console.WriteLine("задание 3");
            //ЗАДАНИЕ 3
            int n, m;//вводим переменные
            for (n = 1; n < 4; n++)//укажет количество строк
            {
                Console.WriteLine();
                for (m = 1; m < 6; m++)//укажет количество символов в строке
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
            Console.WriteLine("задание 4");
            //ЗАДАНИЕ 4
            for (int c = 0; c < 100; c += 3)//так как просто прибавляя три мы и будем получать кратные трём, я решил обойтись без %
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("задание 5");
            //ЗАДАНИЕ 5
            for (int i = 1, j = 40; i - j < 11; i++, j--)// пока разница меньше 11, выводить их значения. Но почему-то он последнее пропускает. А если писать i-j<12, то он пропускает тоже значение, потом пишет с 12.
            {
                Console.WriteLine("i и j: " + i + " " + j);
            }
        }
    }
}
