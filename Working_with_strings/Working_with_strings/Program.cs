using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase1 = "Silencer\nHerald" + "\nis cool";
            string phrase2 = "\n";
            Console.WriteLine(phrase1.Length);
            Console.WriteLine(phrase1[0]); // print out the first character of the string
            Console.WriteLine(phrase1.IndexOf("le"));
            // print out the exact location of where the character or substring is located inside the string;
            // return -1 if the target cannot be found

            Console.WriteLine(phrase1.Substring(2, 4));
            // grab the substring from the original string
            // the first argument is the starting point
            // the second argument shows how many characters we are going to grab

            Console.WriteLine(phrase1.ToUpper());
            Console.WriteLine(phrase1.Contains("cool")); // judge whether the string contains a sub-string

            Console.WriteLine(phrase2.Length);
            Console.ReadLine();
        }
    }
}
