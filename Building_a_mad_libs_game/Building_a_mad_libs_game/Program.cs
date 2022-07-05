using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_mad_libs_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Please enter a color: ");
            color = Console.ReadLine();

            Console.Write("Please enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Please enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}
