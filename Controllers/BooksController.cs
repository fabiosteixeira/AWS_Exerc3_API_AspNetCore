using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using LibraryAPI.Models;
using System.Linq;

namespace LibraryAPI.Controllers 
{
    [Route("Livraria/1.0.0/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase 
    {    
        Book[] books = new Book[] {
            new Book() { Id = 1, Isbn = 9873991, Name = "Seja Foda!", Author = "Caio Carneiro", Editor = "Buzz" },
            new Book() { Id = 2, Isbn = 9730193, Name = "Pai Rico, Pai Pobre", Author = "Robert T. Kiyosaki", Editor = "Alta Books" },
            new Book() { Id = 3, Isbn = 9411225, Name = "A Garota do Lago", Author = "Charlie Donlea", Editor = "Faro editorial" }
        };

        // GET Livraria/1.0.0/books
        //Lista completa de livros
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return books;
        }

        // GET Livraria/1.0.0/books/2
        // Busca um livro pelo isbn
        [HttpGet("{Isbn}")]
        public ActionResult<Book> Get(int Isbn)
        {
            foreach (Book book in books)
            {
                if (book.Isbn==Isbn)
                    return book;
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete("{Isbn}")]
        public ActionResult<IEnumerable<Book>> Delete(int Isbn)
        {
            books = books.Where(book => book.Isbn != Isbn).ToArray();            
            return books;
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] string content)
        {   
            return content;
        }
    }
}