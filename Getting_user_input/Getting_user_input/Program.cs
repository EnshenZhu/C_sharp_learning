using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: "); // print out on the same line
            string name=Console.ReadLine(); // prompt the user to enter

            Console.Write("Enter your age: "); // print out on the same line
            string age = Console.ReadLine(); // prompt the user to enter

            Console.WriteLine("Hello "+name+", your are "+age);

            Console.ReadLine();
        }
    }
}
