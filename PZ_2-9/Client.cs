using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_2_9
{
    internal class Client
    {
        
        public void Error()
        {
            Console.WriteLine($"Деньги кончаются");
        }
        public void NotError()
        {
            Console.WriteLine($"Деньги есть");
        }
    }
}
