using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE
{
    internal class Practice1
    {
        static void Main(string[] args)
        {
            //Practice 1: Write an if statement to check if a number is even. If it is even, display the message "The number [number] is even."

            Console.WriteLine("Input a number to check if it is even:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number " + number + " is even.");

                    }
        }
    }
}
