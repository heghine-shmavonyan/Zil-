using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._3
{
    class Program
    {
        static void Main(string[] args)
        {//Ներածել n բնական թիվը։ Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։

            int n = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= 9; i++) 
            { 
                Console.WriteLine($"{Math.Pow(n,i)} ");
            }
            Console.ReadKey();
        }
    }
}
