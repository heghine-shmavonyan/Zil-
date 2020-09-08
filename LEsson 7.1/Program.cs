using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEsson_7._1
{
    class Program
    {
        static void Main(string[] args)
        {     //Տրված է N բնական թիվը։ Հաշվել 1.1 – 1.2 + 1.3 – … արտահայտության արժեքը։ Նշանափոխ գումարելիների քանակը N է։ Պայմանական (if) օպերատոր չօգտագործել։


            double N = double.Parse(Console.ReadLine());


            
                double sum = 0;
                double sum1 = 0;

                for (double i = 0.1;i<= N / 10; i += 0.2)
                {
                    sum = sum + (i + 1);
                    
                }
                for (double j = 0.2;j<= N / 10; j += 0.2)
                {
                sum1 = sum1 - (j + 1);
                }
            Console.WriteLine(sum+sum1);
                Console.ReadKey();
            
            
        }

    }
}
