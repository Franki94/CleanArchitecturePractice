using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetBooks();
    }
}
