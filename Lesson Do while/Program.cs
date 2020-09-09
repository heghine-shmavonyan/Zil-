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

            int num = int.Parse(Console.ReadLine());
            int num1 = 2;
            int sum = 0;
   
            while (true)
                {
                if (num==1)
                {
                    break;
                }
                if (num%num1==0)
                {
                    num = num / num1;
                    Console.WriteLine(num1);
                    sum = sum + num1;
                }
                else
                {
                    num1++;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
