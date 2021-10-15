using System;

namespace PZ_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[4, 5];//Основной массив
            Random rnd = new Random();//Рандомайзер
            int[] nums1 = new int[5];//Массив для временной записи чисел
            int[] nums2 = new int[5];//Массив максимальных чисел

            for (int i = 0; i<4; i++)//Заполняем массив случаными числами от 0 до 9
            {
                for (int j = 0; j < 5; j++)
                {
                    nums[i, j] = rnd.Next(0, 10);
                    Console.Write(nums[i, j] + " ");//Выводим получившийся массив
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j==0)//Выводим первый столбик
                    {
                        nums1[i] = nums[i, 0];//Присваиваем его значения во временный массив
                    }
                    if (j != i && nums1[j] >= nums1[0] && nums1[j] >= nums1[1] && nums1[j] >= nums1[2] && nums1[j] >= nums1[3] && nums1[j] >= nums1[4])
                    {
                        nums2[0] = nums1[j];//Если его текущее число больше или равно всем остальным, присваеваем это значение конечному одномерному массиву
                    }
                }
            }
            //Далее идут однотипные оперцаии по заполнению всего массива
            Console.Write(nums2[0] + " ");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 1)
                    {
                        nums1[i] = nums[i, 1];
                    }
                    if (j != i && nums1[j] >= nums1[0] && nums1[j] >= nums1[1] && nums1[j] >= nums1[2] && nums1[j] >= nums1[3] && nums1[j] >= nums1[4])
                    {
                        nums2[1] = nums1[j];
                    }

                }
            }
            Console.Write(nums2[1] + " ");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 2)
                    {
                        nums1[i] = nums[i, 2];
                    }
                    if (j != i && nums1[j] >= nums1[0] && nums1[j] >= nums1[1] && nums1[j] >= nums1[2] && nums1[j] >= nums1[3] && nums1[j] >= nums1[4])
                    {
                        nums2[2] = nums1[j];
                    }

                }
            }
            Console.Write(nums2[2] + " ");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 3)
                    {
                        nums1[i] = nums[i, 3];
                    }
                    if (j != i && nums1[j] >= nums1[0] && nums1[j] >= nums1[1] && nums1[j] >= nums1[2] && nums1[j] >= nums1[3] && nums1[j] >= nums1[4])
                    {
                        nums2[3] = nums1[j];
                    }

                }
            }
            Console.Write(nums2[3] + " ");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 4)
                    {
                        nums1[i] = nums[i, 4];
                    }
                    if (j != i && nums1[j] >= nums1[0] && nums1[j] >= nums1[1] && nums1[j] >= nums1[2] && nums1[j] >= nums1[3] && nums1[j] >= nums1[4])
                    {
                        nums2[4] = nums1[j];
                    }

                }
            }
            Console.Write(nums2[4] + " ");//Вывести массив
            Console.WriteLine();
            //До конца правильно сделать не получилось, так как последнее число в столбце он не учитывает. Но я не разобрался, как правильно сделать проверку.
        }
    }
}
