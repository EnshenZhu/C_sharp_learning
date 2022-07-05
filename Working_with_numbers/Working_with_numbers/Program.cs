using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + 8); // this will output 13
            Console.WriteLine(5 + 8.2); // this will output 13.2

            Console.WriteLine(5 % 2);

            Console.WriteLine(5 / 2);  // this will output 2
            Console.WriteLine(5 / 2.0); // this will output 2.5
            
            int num = 6;
            Console.WriteLine(--num);

            Console.WriteLine(-num);

            Console.WriteLine(Math.Abs(num));

            Console.WriteLine(Math.Pow(num, 0.5));
            Console.WriteLine(Math.Sqrt(num));

            Console.ReadLine();
        }
    }
}
