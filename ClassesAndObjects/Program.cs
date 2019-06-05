using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            /* [ Simplified version ]
             * Book book1 = new Book
             *  {
             *     title = "Goblet of Fire",
             *      author = "J.K. Rowling",
             *      pages = 734
             *  };
             * 
             */

            Book book1 = new Book("Goblet of Fire", "J.K. Rowling", 734);
            //book1.title = "Goblet of Fire";
            //book1.author = "J.K. Rowling";
            //book1.pages = 734;

            Book book2 = new Book("Two Towers", "J.R.R. Tolkien", 352);
            //book2.title = "Two Towers";
            //book2.author = "J.R.R. Tolkien";
            //book2.pages = 352;

            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
    }
}
