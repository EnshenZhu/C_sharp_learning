using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args) // Main method
        {
            SayHi("Peter",33);
            SayHi("Tome",25);
            SayHi("John",14);
            Console.ReadLine();
        }

        static void SayHi(string Name,int age) // this method does not return anything, which does void return
        {
            Console.WriteLine("Hello, " + Name+" your are "+age);
        }
    }
}
