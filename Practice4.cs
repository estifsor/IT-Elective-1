using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Practice4
    {
        static void Main(string[] args)
        {
            //Practice 4: Write a C# program using a ternary operator to determine if a student has passed or failed an exam. 
            //The passing score is 50. Print "Passed" if the score is 50 or above, otherwise print "Failed".

            Console.WriteLine("Kindly enter your score to know if you passed or failed the exam.");
            int score = Convert.ToInt32(Console.ReadLine());

            string result = (score > 50) ? "PASSED" : "FAILED";
            Console.WriteLine(result);
        }
    }
}
