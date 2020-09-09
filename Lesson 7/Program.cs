using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Program
    {


        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Numbers(a, b);
            SumNumbers();
            MultipleTo3Numbers();
            SumOfNumbers();
            SumOfOddNumbers();
            MultipleOfNumbers();
            SumCountOfNumbers();
        }


        static void Numbers(int a,int b)
        {
            
            //6 տրված են a և b (a < b) ամբողջ թվերը։ արտածել աճման կարգով [a, b] հատվածին պատկանող ամբողջ թվերը, ապա նաև նրանց քանակը։

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(b - a + 1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("please enter number a and b where a < b");
                Console.ReadKey();
            }
        }


        static void SumNumbers()
        {
            //7 Տրված են A և B (A < B) ամբողջ թվերը։ Գտնել [A, B] հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A < B)
            {
                int sum1 = 0;
                for (int i = A; i <= B; i++)
                {
                    sum1 = sum1 + i;
                }
                Console.WriteLine(sum1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please enter number A and B where A < B");
                Console.ReadKey();
            }
        }
        static void MultipleTo3Numbers()
        {
            
            // 8 Տրված են A և B (A < B) ամբողջ թվերը։ Գտնել [A, B] հատվածին պատկանող 3-ին պատիկ առաջին թիվը։

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A < B)
            {
                for (int i = A; i <= B; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("There isn't number divisible into 3");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please enter number A and B where A < B");
                Console.ReadKey();
            }
        }

        static void SumOfNumbers()
        {
            // 9 Տրված է N բնական թիվը։ Հաշվել 1 + 1/2 + 1/3 + … + 1/N գումարը (այն իրական թիվ է)։

            int N = int.Parse(Console.ReadLine());

            if (N > 0)
            {
                double sum2 = 0;
                for (double i = 1; i <= N; i++)
                {
                    sum2 = sum2 + 1 / i;
                }
                Console.WriteLine(sum2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please enter Natural number");
                Console.ReadKey();
            }
        }

        static void SumOfOddNumbers()
        {
            //10 Տրված է N բնական թիվը։ Հաշվել N2 + (N + 1)2 + (N + 2)2 + … + (2·N)2 գումարը։

            int N1 = int.Parse(Console.ReadLine());

            Double sum = 0;
            for (int i = N1; i <= 2 * N1; i++)
            {
                sum = sum + Math.Pow(i, 2);
            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }


        static void MultipleOfNumbers()
        {
            //11 Տրված է N բնական թիվը։ Հաշվել 1.1 · 1.2 · 1.3 · … արտադրյալը (արտադրիչների քանակը N է)։

            double N2 = double.Parse(Console.ReadLine());

            if (N2 > 0)
            {
                double sum2 = 1;

                for (double i = 0; i <= N2 / 10; i += 0.1)
                {
                    sum2 = sum2 * (i + 1);
                    Console.WriteLine(i);
                }
                Console.WriteLine(sum2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please enter Natural number");
                Console.ReadKey();
            }
        }


        static void SumCountOfNumbers()
        {
            //12/Տրված է N բնական թիվը։ Հաշվել 1.1 – 1.2 + 1.3 – … արտահայտության արժեքը։ Նշանափոխ գումարելիների քանակը N է։ Պայմանական (if) օպերատոր չօգտագործել։

            double N = double.Parse(Console.ReadLine());

            double sum = 0;
            double sum1 = 0;

            for (double i = 0.1; i <= N / 10; i += 0.2)
            {
                sum = sum + (i + 1);

            }
            for (double j = 0.2; j <= N / 10; j += 0.2)
            {
                sum1 = sum1 - (j + 1);
            }
            Console.WriteLine(sum + sum1);
            Console.ReadKey();

        }

    }


}
