using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine(numberGrid[0, 0]);

            int[,] numberGrid2 = new int[3, 2];
            int count = 1;

            Console.WriteLine(numberGrid2.GetLength(0));
            Console.WriteLine(numberGrid2.GetUpperBound(0));

            for (int i = 0; i < numberGrid2.GetLength(0); i++)
            {
                for (int j = 0; j < numberGrid2.GetUpperBound(0); j++)
                {
                    numberGrid2[i, j] = count;
                    Console.Write(numberGrid2[i, j]+" ");

                    count++;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
