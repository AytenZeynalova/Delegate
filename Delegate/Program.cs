using System;
using ClassLibrary;



namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();

            book1.Name = "Kitab1";
            book1.Genre = Genre.gizemli;
            book1.Price = 20;


            book2.Name = "Kitab2";
            book2.Genre = Genre.macera;
            book2.Price = 25;


            book3.Name = "Kitab3";
            book3.Genre = Genre.qorxu;
            book3.Price = 30;

            Library library = new Library();
            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);


            Console.WriteLine("Butun kitablar:::");
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Butun kitablarin qiymetleri::");
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Price);
            }

            Console.WriteLine("Janra gore kitablar::");
            foreach (var item in library.FilterByGenre(Genre.gizemli))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
            }

            Console.WriteLine("Qiymete gore::");
            foreach (var item in library.FilterByPrice(10,23))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
            }

            Console.WriteLine("nomreye gore::");

            Console.WriteLine(library.FindBookByNo(3).Name);
            Console.WriteLine(library.FindBookByNo(3).Price);


            Console.WriteLine("Nomreye gore yoxlama::");
            Console.WriteLine(library.isExistBookByNo(5));


            Console.WriteLine("Kitabi sil::");

        }
    }
}
