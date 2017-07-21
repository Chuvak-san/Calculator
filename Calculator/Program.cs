using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static void Main()
        {
            
            
            Console.WriteLine("Enter nuber one:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter nuber two:");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operation?");
            string todo = Convert.ToString(Console.ReadLine());
            if (todo == "+") {
                Console.WriteLine("The result is - " + (num_1 + num_2));
            }
            if (todo == "-")
            {
                Console.WriteLine("The result is - " + (num_1 - num_2));
            }
            if (todo == "*")
            {
                Console.WriteLine("The result is - " + (num_1 * num_2));
            }
            if (todo == "/")
            {
                if (num_2 == 0)
                {
                    Console.WriteLine("No no no");
                }
                else Console.WriteLine("The result is - " + (num_1 / num_2));
                }
            }
                       Console.ReadKey();
        }
    }
}