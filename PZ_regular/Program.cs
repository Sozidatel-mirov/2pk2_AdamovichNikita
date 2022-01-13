using System;
using System.Text.RegularExpressions;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"new contact tel:123-45-65, 123-45-56; fax:123-53-23.
 old contact tel:242-21-24";
            Console.WriteLine("Старые данные:\n" + text);

            string newText = Regex.Replace(text, "tel[:]?", "");
            Console.WriteLine("Новые данные:\n" + newText);

            string NewText = Regex.Replace(newText, "fax[:]?", "");
            Console.WriteLine("Новые данные:\n" + NewText);

            Regex r = new Regex(@"\d\d\.\d\d\.\d\d");
            Regex r1 = new Regex(@"\d\d[.:]\d\d");
            Regex r2 = new Regex(@"[-+]?\d+");
            Regex r3 = new Regex(@"[-+]?\d+\.\d+");
            string text1 = @"14.12.21 Шёл 30-ый день зимы, 23:34";
            Match Date = r.Match(text1);
            while (Date.Success)
            {
                Console.WriteLine(Date);
                Date = Date.NextMatch();
            }
            Match Date1 = r1.Match(text1);
            while (Date1.Success)
            {
                Console.WriteLine(Date1);
                Date1 = Date1.NextMatch();
            }
            Match Date2 = r2.Match(text1);
            while (Date2.Success)
            {
                Console.WriteLine(Date2);
                Date2 = Date2.NextMatch();
            }
            Match Date3 = r3.Match(text1);
            while (Date3.Success)
            {
                Console.WriteLine(Date3);
                Date3 = Date3.NextMatch();
            }

        }
    }
}
