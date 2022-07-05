using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;
        // the above three are public class attributes

        public Book(string aTitle, string aAuthor, int aPages) // constructor
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public Book() // you can have multiple constructors
        {

        }
        
    }
}
