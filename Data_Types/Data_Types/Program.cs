using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Silencer";
            char grade = 'A'; //    you can only put one single character inside the char_typed variable
            int age = 30;

            //  there are three different ways to store decimal numbers in C#
            //  float - least precise
            //  double
            //  decimal - most precise (like money)
            float height;
            double gpa = 3.2;
            decimal wage;

            bool isMale = false; //  True or false

            Console.WriteLine(phrase);
            Console.WriteLine(grade);
            Console.WriteLine(age);
            Console.WriteLine(gpa);
            Console.WriteLine(isMale);

            Console.ReadLine();
        }
    }
}
