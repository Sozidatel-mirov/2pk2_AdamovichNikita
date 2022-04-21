using System;
using System.Threading;

delegate void MyDelegate();
namespace PZ_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bancc chet = new Bancc(25);
            Client client = new Client();
            chet.MyEvent += client.Error;
            Console.WriteLine("Создать автоплатёж");
            chet.avtoplatej();
            chet.MyEvent -= client.Error;
            chet.MyEvent += client.NotError;
            Console.WriteLine("Внести 10000");
            chet.vnesti(10000);
            chet.avtoplatej();
        }
    }
}
