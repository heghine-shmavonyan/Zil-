using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._2
{
    class Program
    {
        static void Main(string[] args)
        {//Ներածել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։

            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<=n;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
