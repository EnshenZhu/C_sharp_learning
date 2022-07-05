using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cubedNumer = Cube(5);
            
            Console.WriteLine(cubedNumer);
            Console.ReadLine();
        }

        static double Cube(double num)
        {
            double result = num * num * num;
            return result;
        }
    }
}
