using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Practice2
    {
        static void Main(string[] args)
        {
            //Practice  2: Write an if-else statement to determine if a number is positive or negative. If the number is positive. display the message 
            // "the number [number] is positive." Otherwise, display the message "The number [number] is negative."
            
            Console.WriteLine("Input a number to check if it is positive or negative:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("The number " + number + " is positive.");
            }
            else
            {
                Console.WriteLine("The number " + number + " is negative");
            }

        }
    }
}
