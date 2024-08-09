using Application.Interfaces;
using Domain;

namespace Application.Features.Books;

public class GetBooksQuery(IBookRepository bookRepository)
{
    public List<BookEntity> Handle()
    {
        return bookRepository.GetBooks();
    }
}
