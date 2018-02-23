using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModule3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fib = 0;
            int dop = 0;
            for (int i = 1; i <= 50; i++)
            {
                Fib = Fib + dop;
                if (i == 1)
                    dop++;
                dop = dop + Fib;
                Console.WriteLine(Fib);
                Console.WriteLine(dop);
            }
        }
    }
}
