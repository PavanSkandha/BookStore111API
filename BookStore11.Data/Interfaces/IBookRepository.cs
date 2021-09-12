using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookStore11.Data.Interfaces
{
  public  interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
    }
}
