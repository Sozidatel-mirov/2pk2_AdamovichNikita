using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_2_9
{
    internal class Bancc
    {
        public int chet;
        public Bancc(int ppp)
        {
            chet = ppp;
        }
        public event MyDelegate MyEvent;

        public void avtoplatej()
        {
            for(int i = 0; i < chet; i = 0)
            {
                chet--;
                if (chet < 10)
                {
                    if (MyEvent != null)
                    {
                        MyEvent();
                    }
                }
                Console.WriteLine(chet);
            }  
        }
        public void vnesti(int sum)
        {
            chet += sum;
            if (chet > 10)
            {
                if (MyEvent != null)
                {
                    MyEvent();
                }
            }
            Console.WriteLine(chet);
        }
    }
}
