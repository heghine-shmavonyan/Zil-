using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {//Տրված են K և N (N > 0) ամբողջ թվերը։ N անգամ արտածել K թիվը։
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(K);
            }
            int m = 0;
            //second way
            while (m < N)
            {
                m++;
                Console.WriteLine(K);
            }

            Console.ReadKey();
        }
    }
}
