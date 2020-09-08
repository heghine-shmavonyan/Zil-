using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 13, 43, 53, 23, 3, 5, 46, 34, 5, 6, 765, 97, 9, 7, 54, 67, 35, 6, 5, 43 };
            int[] oddNumbers = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    oddNumbers[i] = nums[i];
                }

            }
            int minValue = int.MaxValue;
            for (int i = 0; i < oddNumbers.Length; i++)
            {
                if (oddNumbers [i] < minValue && oddNumbers[i]!= 0)
                { 
                    minValue = oddNumbers[i];

                }
               

            }
            Console.WriteLine(minValue);
            Console.ReadLine();
        }
    }
}
