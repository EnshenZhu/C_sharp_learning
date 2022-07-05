using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling",400); // this is an instance of a book class
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.pages);

            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700); // this is an instance of a book class
            //book2.title = "Lord Of the Rings";
            //book2.author = "Tolkein";
            //book2.pages = 700;

            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            Book book3 = new Book();
            book3.title = "Hobby";

            Console.WriteLine(book3.title);

            Console.ReadLine();
        }
    }
}
