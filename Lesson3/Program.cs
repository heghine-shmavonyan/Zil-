using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 21;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.ReadKey();

            float m = 20.3456f;
            float n = 27.345625f;
            Console.WriteLine(m + n);
            Console.WriteLine(m - n);
            Console.WriteLine(m * n);
            Console.WriteLine(m / n);
            Console.WriteLine(m % n);
            Console.ReadKey();


            int l = 235;
            byte k = (byte)l;
            Console.WriteLine(k);
            Console.ReadKey();

            int g = 4000;
            byte f = (byte)g;
            Console.WriteLine(f);
            Console.ReadKey();

            int c = 235;
            byte y;
            checked
               
            { 
                y = (byte)c; 
            }
            
            Console.WriteLine("For checked one "+ y);
            Console.ReadKey();

            int e = 2353;
            byte u;

            unchecked

            {
                u = (byte)e;
            }

            Console.WriteLine("For unchecked one " + u);
            Console.ReadKey();


        }
    }
}
