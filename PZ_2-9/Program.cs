using System;
using System.Threading;

delegate void MyDelegate();
namespace PZ_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bancc chet = new Bancc(1000);
            Client client = new Client(chet);

            client.slejka();
            Console.WriteLine();
            Console.WriteLine("Снять 990");
            chet.sniat(990);
            client.slejka();
            Console.WriteLine();
            Console.WriteLine("Внести 1000");
            chet.vnesti(1000);
            client.slejka();
        }
    }
}
