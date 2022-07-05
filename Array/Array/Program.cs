using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers1 = { 4, 8, 15, 16, 23, 42 }; // create an array of integers
            
            Console.WriteLine(luckyNumbers1[0]);

            int[] luckyNumbers2 = luckyNumbers1; // soft copy

            int[] luckyNumbers3 = new int[luckyNumbers1.Length]; // hard copy
            for (int i = 0; i < luckyNumbers3.Length; i++)
            {
                luckyNumbers3[i] = luckyNumbers1[i];
            }

            luckyNumbers1[0] = 12;
            Console.WriteLine(luckyNumbers2[0]);
            Console.WriteLine(luckyNumbers3[0]);

            string[] friends = new string[10];
            friends[0] = "Tommy";
            friends[1] = "Bob";

            Console.WriteLine(friends);

            Console.ReadLine();
        }
    }
}
