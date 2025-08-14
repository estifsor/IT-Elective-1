using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Practice5
    {
        static void Main(string[] args)
        {
            
            //Practice 5: Create a program that allows the user to choose betweeen computing the area or the perimeter of a circle.

            Console.WriteLine("Enter the letter of your choice. A - Compute the area of circle / P - Compute the perimeter of the circle / X - Exit");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'A':
                    Console.WriteLine("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double area = 3.1416 * radius * radius;
                    Console.WriteLine("The area of cirle is " + area);
                    break;

                case 'P':
                    Console.WriteLine("Enter radius: ");
                    double radius1 = Convert.ToDouble(Console.ReadLine());
                    double perimeter = 2 * 3.1416 * radius1;
                    Console.WriteLine("The perimeter of the circle is " + perimeter);
                    break;

                case 'X':
                    break;
                default:
                    break;
            }
            }
    }
}
