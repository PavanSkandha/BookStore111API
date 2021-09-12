using BookStore11.Data.Interfaces;
using BookStore11.Data.Repositories;
//using BookStore111API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore111API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //  public List<Book> books = new List<Book>()
        //  {
        //     new Book {Id=1,Title="the girl",Author="haukins",PublicationYear=2016,CallNumber="defgh"},
        //    new Book {Id=2,Title="the boy",Author="paukins",PublicationYear=2017,CallNumber="oefgh"},
        // };

        private BookRepository books = new BookRepository();
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            // var book = books.FirstOrDefault(x => x.Id == id);
            var book = books.GetBook(id);

            if(book==null)
            {
                return NotFound();
            }
            return book;
        }
    }
}
