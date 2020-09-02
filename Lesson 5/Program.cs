using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {    // Task 1
            Console.WriteLine("Write a number from 1 to 7 ");

            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Wrong input");
                    }
                    break;
            }


            //Task 2

            Console.WriteLine("Write a number");

            Int32 num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine("The written number divided into 2 or 3");
            }

            else
            {
                Console.WriteLine("The written number isn't divided into 2 or 3");

            }


            //Task 2.1

            Console.WriteLine("Write a number");

            Int32 num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num1 % 2 == 0 || num1 % 3 == 0 ? "The written number divided into 2 or 3" : "The written number isn't divided into 2 or 3");

            //Task 3

            Console.WriteLine("Write an odd and natural number");

            Int32 num2 = Int32.Parse(Console.ReadLine());
            if (num2 > 0 && num2 % 2 != 0)
            {
                Console.WriteLine("The number is natural and odd");
            }
            else
            {
                Console.WriteLine("The number is not natural and odd");
            }

            //Task 3.1

            Console.WriteLine("Write an odd and natural number");

            Int32 num3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num3 > 0 && num3 % 2 != 0 ? "The number is natural and odd" : "The number is not natural and odd");
            

            //Task 4 
            Console.WriteLine("Write a number");

            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int num6;
            num6 = num4 + num5;
            num5 = num6 - num5;
            num4 = num6 - num4;

            Console.WriteLine(num4);
            Console.WriteLine(num5);

            //Task 4.1
            Console.WriteLine("Write a number");

            int num7 = int.Parse(Console.ReadLine());
            int num8 = int.Parse(Console.ReadLine());
            num7 = num7 + num8;
            num8 = num7 - num8;
            num7 = num7 - num8;

            Console.WriteLine(num7);
            Console.WriteLine(num8);
            Console.ReadKey();



        }

    }
}
