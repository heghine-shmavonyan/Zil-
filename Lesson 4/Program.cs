using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int c = Int32.Parse(a);
            Console.WriteLine(c);
            int d = Convert.ToInt32(b);
            Console.WriteLine(d);
           


            string g = Console.ReadLine();//h=7456
            int h = Int32.Parse(g);
            int m = h / 1000; // m = 7 
            int k = h - (m * 1000); // k=456
            int n = k / 100; // n= 4
            int u = k - (n * 100); //u=56
            int t = u / 10; //t= 5
            int o = u - (t * 10);//o=6


            int res = m + n + t + o;
            int res2 = m * n * t * o;
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.ReadKey();

            string aa = Console.ReadLine();
            string aaa = Console.ReadLine();
            double aaaa = Double.Parse(aa);
        }
    }
}
