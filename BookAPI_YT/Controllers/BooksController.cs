using BookAPI_YT.Models;
using BookAPI_YT.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI_YT.Controllers
{
    //[Route("/api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
        
        
    {
        private readonly IBookRepositories _bookRepositories;
        public BooksController(IBookRepositories bookRepositories)
        {
            _bookRepositories = bookRepositories;
        }
        [HttpGet("/api/books")]
  
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepositories.GetB();
        }
        [HttpGet("/api/books/{id}")]
     
        public async Task<ActionResult<Book>> GetBooks(int id)
        {
            return await _bookRepositories.Get(id);
        }


        [HttpPost("/api/books")]
   
        public async Task<ActionResult<Book>>PostBooks([FromBody] Book book)
        {
            var newBook = await _bookRepositories.Create(book);
            return CreatedAtAction(nameof(GetBooks), new { id = newBook.Id }, newBook);
        }
        [HttpPut("/api/books/{id}")]
 
        public async Task<ActionResult> PutBooks( int id , [FromBody] Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }
            await _bookRepositories.Update(book);
            return NoContent();
        }
    }
}
