using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Practice3
    {
        static void Main(string[] args)
        {
            //Practice 3: Write an if-else ladder to categorize a person based on their age and monthly income.

            Console.WriteLine("In what category are you included?");
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your income: ");
            int income = Convert.ToInt32(Console.ReadLine());

            if (age >= 25 && age <= 35 && income > 50000)
                {
                Console.WriteLine("YOUNG PROFESSIONAL");
            }

            else if (age >= 36 && age <= 55 && income > 70000)
                    {
                Console.WriteLine("MIDDLE-AGED PROFESSIONAL");
            }

            else if (age >= 56 && income < 30000)
            {
                Console.WriteLine("SENIOR CITIZEN");
            }

            else {
                Console.WriteLine("OTHER");
                    }

        }
    }
}
