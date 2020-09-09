using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Խնդիր_21:Արտածել տրված թվի բոլոր բաժանարարները։
            //Խնդիր_22:Հաշվել տրված թվի բոլոր բաժանարարների գումարը։
            //Խնդիր_23:Հաշվել տրված թվի բոլոր բաժանարարների գումարի և դրանց քանակի քանորդը։

            int num = int.Parse(Console.ReadLine());
            int num1 = 2;
            int sum = 0;
            double count = 0;

   
            while (true)
                {
                if (num==1 || num ==0)
                {
                    return;
                }
                if (num%num1==0)
                {
                    num = num / num1;
                    Console.WriteLine(num1);
                    sum = sum + num1;
                    count++;
                }
                else
                {
                    num1++;
                }

            }
            Console.WriteLine(sum);
            Console.WriteLine(sum/count);
            Console.ReadKey();

        }
    }
}
