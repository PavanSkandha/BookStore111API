using BookStore11.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore11.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> books = new List<Book>()
        {
            new Book {Id=1,Title="the girl",Author="haukins",PublicationYear=2016,CallNumber="defgh"},
            new Book {Id=2,Title="the boy",Author="paukins",PublicationYear=2017,CallNumber="oefgh"},
        };
        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
    }
}
