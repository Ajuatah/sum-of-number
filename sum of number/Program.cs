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
            int[] list = new int[3];

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"Enter {i + 1} number: ");
                int value = int.Parse(Console.ReadLine());
                list[i] = value;
            }
            Array.Sort(list);
            Array.Reverse(list);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();  
        }
    }
}
