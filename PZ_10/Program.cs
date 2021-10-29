using System;

namespace PZ_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mas1 = new int[10][];
            Random rnd = new Random();
            int[] mas3 = new int[10];
            int[] mas4 = new int[10];
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = new int[rnd.Next(3, 10)];
                for (int j = 0; j < mas1[i].Length; j++)
                {
                    mas1[i][j] = rnd.Next(3, 50);
                }
            }
            int max = mas1[0][0];
                foreach (int[] mas2 in mas1)
            {
                foreach(int n in mas2)
                {
                    Console.Write(n + " ");
                }

            Console.WriteLine();
                }
                 Console.WriteLine();
                for (int i = 0, k = 0; i < mas1.Length; i++, k++)
                {
                    for (int j = 0; j < mas1[i].Length; j++)
                    {
                        mas3[k] = mas1[i][mas1[i].Length - 1];
                    }
                    Console.Write(mas3[k] + " ");
                }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < mas1[0].Length; i++)
            {
                if (max < mas1[0][i])
                {
                    max = mas1[0][i];
                }
            }
            mas4[0] = max;

            max = mas1[4][0];
            for (int i = 1; i < mas1[4].Length; i++)
            {
                if (max < mas1[4][i])
                {
                    max = mas1[4][i];
                }
            }
            mas4[4] = max;

            max = mas1[1][0];
            for (int i = 1; i < mas1[1].Length; i++)
            {
                if (max < mas1[1][i])
                {
                    max = mas1[1][i];
                }
            }
            mas4[1] = max;

            max = mas1[2][0];
            for (int i = 1; i < mas1[2].Length; i++)
            {
                if (max < mas1[2][i])
                {
                    max = mas1[2][i];
                }
            }
            mas4[2] = max;

            max = mas1[3][0];
            for (int i = 1; i < mas1[3].Length; i++)
            {
                if (max < mas1[3][i])
                {
                    max = mas1[3][i];
                }
            }
            mas4[3] = max;

            max = mas1[5][0];
            for (int i = 1; i < mas1[5].Length; i++)
            {
                if (max < mas1[5][i])
                {
                    max = mas1[5][i];
                }
            }
            mas4[5] = max;

            max = mas1[6][0];
            for (int i = 1; i < mas1[6].Length; i++)
            {
                if (max < mas1[6][i])
                {
                    max = mas1[6][i];
                }
            }
            mas4[6] = max;

            max = mas1[7][0];
            for (int i = 1; i < mas1[7].Length; i++)
            {
                if (max < mas1[7][i])
                {
                    max = mas1[7][i];
                }
            }
            mas4[7] = max;

            max = mas1[8][0];
            for (int i = 1; i < mas1[8].Length; i++)
            {
                if (max < mas1[8][i])
                {
                    max = mas1[8][i];
                }
            }
            mas4[8] = max;

            max = mas1[9][0];
            for (int i = 1; i < mas1[9].Length; i++)
            {
                if (max < mas1[9][i])
                {
                    max = mas1[9][i];
                }
            }
            mas4[9] = max;
            for (int i = 0; i < 10; i++)
                Console.Write(mas4[i] + " ");

           

        }
    }
}
