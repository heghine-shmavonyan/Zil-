using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._4
{
    class Program
    {
        static void Main(string[] args)
        {//Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ առանց զույգությունը ստուգելու։

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= n; i+=2)
            {
                sum += i;
               
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

