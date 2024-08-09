using Application.Interfaces;
using Domain;

namespace Application.Features.Books;

public class GetBookByIdQuery(IBookRepository bookRepository)
{
    public BookEntity Handle(int id)
    {
        return bookRepository.GetBook(id);
    }
}
