using System;
struct Pupil
{
    public string name;
    public int[] Datab;
    public string zodiac;
    public Pupil(string n, string group, int[] ses)
    {
        Datab = ses;
        name = n;
        zodiac = group;
    }
    public void Show()
    {
        Console.WriteLine($"Человек {name}\nЗодиак {zodiac}  \nДата рождения: ");//Вывод имени и знака
        for (int i = 0; i < Datab.Length; i++)//Вывод даты рождения
        {
            Console.Write(Datab[i]);
            if (i != Datab.Length - 1)
                Console.Write(".");
        }
        Console.WriteLine();
    }
}
internal class Program
{
    static void Main()
    {
        string data;//Строка для считывания сообщения пользователя
        string[] data1;//Массив, выбирающий разделённые числа из введённой даты
        Pupil[] BOOK = new Pupil[2];
        for (int i = 0; i < BOOK.Length; i++)
        {
            Console.Write($"Введите Имя Персонажа {i + 1}: ");
            BOOK[i].name = Console.ReadLine();
            Console.Write("Введите Его Знак: ");
            BOOK[i].zodiac = Console.ReadLine();
            Console.Write("Введите Дату рождения в формате гг.мм.дд: ");
            data = Console.ReadLine();
            BOOK[i].Datab = new int[3];
            data1 = data.Split('.');//Разделить введённйю дату на подстроки
            for (int j = 0; j < 3; j++) BOOK[i].Datab[j] = Convert.ToInt32(data1[j]);//соединение подстрок в числовом значении
            Console.WriteLine();
        }
        // Вывести все элементы BOOK
        //for (int i = 0; i < BOOK.Length; i++)
        //{
        //    Console.WriteLine("-------------------");
        //    BOOK[i].Show();
        //    Console.WriteLine("-------------------");
        //}
        Console.WriteLine("Введите имя для поиска: ");
        string peremen = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < BOOK.Length; i++)
        {
            if (BOOK[i].name == peremen)
            {
                Console.WriteLine("-------------------\n-------------------");
                BOOK[i].Show();
                count++;
                Console.WriteLine("-------------------\n-------------------");
            }
        }
        if (count == 0) Console.WriteLine("Error");

    }
}