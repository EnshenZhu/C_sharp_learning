using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("part1");
            int index = 1;
            while (index<=5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("part2");
            int index2 = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            }while (index2<5); // the do...while loop will execute the loop before checking the condition
            
            Console.ReadLine();
        }
    }
}
