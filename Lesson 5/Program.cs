﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Write a number from 1 to 7 ");

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
            Console.ReadKey();


        }
    }
}
