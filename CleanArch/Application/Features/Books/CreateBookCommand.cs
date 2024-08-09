using Application.Interfaces;
using Domain;

namespace Application.Features.Books;

public class CreateBookCommand(IBookRepository bookRepository)
{
    public void Handle(BookEntity book)
    {
        bookRepository.AddBook(book);
    }
}
