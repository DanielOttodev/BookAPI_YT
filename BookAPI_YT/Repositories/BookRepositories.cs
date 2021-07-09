using BookAPI_YT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI_YT.Repositories
{
    public class BookRepositories : IBookRepositories

    {
        private readonly BookContext _context;

        public BookRepositories(BookContext context)
        {
            _context = context;
        }
        public async Task<Book> Create(Book book)
        {

            var lastBook = await _context.Books.OrderByDescending(x => x.Id).FirstOrDefaultAsync(); // Get the last book by Id
            book.Id = lastBook.Id + 1;
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id); // Await till book is found
            _context.Books.Remove(bookToDelete);
        }

        public async Task<IEnumerable<Book>> GetB()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            return await _context.Books.FindAsync(id);
           
        }

        public async Task Update(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


    }
}
