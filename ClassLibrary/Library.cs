using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public  class Library
    {
      public   List<Book> Books = new List<Book>();

       public  List<Book> FilterByPrice(double min, double max)
        {
            List<Book> filteredByPricesBooks = new List<Book>();
            foreach (var item in Books)
            {
                if(item.Price>=min && item.Price <= max)
                {
                    filteredByPricesBooks.Add(item);
                }
            }return filteredByPricesBooks;
        }

        public List <Book> FilterByGenre(Genre genre)
        {
            List<Book> FilteredByGenre = new List<Book>();

            foreach (var item in Books)
            {
                if (item.Genre == genre)
                {
                    FilteredByGenre.Add(item);
                }
            }return FilteredByGenre;
        }

        public Book FindBookByNo(int NO)
        {
            foreach (var item in Books)
            {
                if (item.No == NO)
                {
                    return item;
                }
            }return null;
        }

        public bool isExistBookByNo(int NO)
        {
            bool check = false;
            foreach (var item in Books)
            {
                if (item.No == NO)
                {
                    return true;
                }
            }return false;
        }

        public List<Book> RemoveAll(Predicate<Book> predicate)
        {
            List<Book> RemovingBooks = new List<Book>();
            foreach (var item in Books)
            {
                if (predicate(item))
                {
                    RemovingBooks.Add(item);
                }
            }
            Books = RemovingBooks;
            return Books;
        }

    }
}
