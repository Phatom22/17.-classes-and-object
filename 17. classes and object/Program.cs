using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.classes_and_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "harry potter";
            book1.author = "jefferson";
            book1.pages = 23;

            Book book2 = new Book();
            book2.title = "jaguar";
            book2.author = "jerry";
            book2.pages = 40;

            Book book3 = new Book();
            book3.title = "analytics";
            book3.author = "jupa";
            book3.pages = 230;

            Book book4 = new Book();
            book4.title = "peterson";
            book4.author = "jefferson";
            book4.pages = 240;

            Book book5 = new Book();
            book5.title = "spider man";
            book5.author = "jefferson";
            book5.pages = 600;


            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            Console.WriteLine(book3.title);
            Console.WriteLine(book3.author);
            Console.WriteLine(book3.pages);


            Console.WriteLine(book4.title);
            Console.WriteLine(book4.author);
            Console.WriteLine(book4.pages);


            Console.WriteLine(book5.title);
            Console.WriteLine(book5.author);
            Console.WriteLine(book5.pages);
            Console.ReadLine();
        }
    }
}
