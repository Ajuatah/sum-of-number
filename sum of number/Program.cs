using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool parseSucceed = false;
            int count = 0;
            int sum =0;

            do
            {
                Console.WriteLine($"Enter {count+1} number");
                parseSucceed =  Int32.TryParse(Console.ReadLine(), out int number);
                sum += number;
                count++;
               
            }
            while (parseSucceed &&  count <5);

            Console.WriteLine($"The sum is {sum}");


            Console.ReadKey();  
        }
    }
}
