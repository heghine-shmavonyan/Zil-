using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num5 = int.Parse(Console.ReadLine());

            MinOddGreater4Value(num5);
            LessThan7(num5);
            MinOddValue(num5);
            Console.ReadLine();

        }
        static void MinOddValue(int num)
        { //Խնդիր_17 Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։


            string num1 = num.ToString();
            int[] nums = new int[num1.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                nums[i] = int.Parse(num1[i].ToString());
            }
            int minValue = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < minValue && nums[i] % 2 != 0)
                {
                    minValue = nums[i];
                }
            }

            Console.WriteLine(minValue);

        }



        static void MinOddGreater4Value(int num)
        {//Խնդիր_18 Հաշվել տրված թվի 4-ից մեծ կենտ թվանշանների գումարը։
            string num1 = num.ToString();
            int[] nums = new int[num1.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                nums[i] = int.Parse(num1[i].ToString());
            }
            int minValue = int.MaxValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0 && nums[i] > 4)
                {
                    minValue = nums[i];
                    sum = sum + nums[i];
                }
                
            }

            Console.WriteLine(sum);


        }
        static void LessThan7(int num)
        {//Խնդիր_19 Հաշվել տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։


            string num1 = num.ToString();
            int[] nums = new int[num1.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                nums[i] = int.Parse(num1[i].ToString());
            }
            int multiply = 1;
            int minValue = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && nums[i] < 7)
                {
                    minValue = nums[i];
                    multiply = multiply * nums[i];
                }

            }

            Console.WriteLine(multiply);

        }
    }
}
