using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            int [] nums  = new int[] {5,4,3,8,6,9,7};
            for (int i = 0; i <= nums.Length; i++)
            {
                if (nums[i] * nums[i] < nums[nums.Length-i] * nums[nums.Length - i])

                {
                    Console.WriteLine(nums[i]);
                }

            }

            Console.ReadKey();

        }

        
    }
}
