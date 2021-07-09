using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI_YT.Models;
namespace BookAPI_YT.Repositories
{
    public interface IBookRepositories
    {
        Task<IEnumerable<Book>> GetB();

        Task<Book> Get(int id);


        Task<Book> Create(Book book);

        Task Update(Book book);

        Task Delete(int id);
    }
}
