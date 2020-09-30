using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CleanArchitecture.Infra.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _libraryDbContext;
        public BookRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _libraryDbContext.Books.AsNoTracking();
        }
    }
}
