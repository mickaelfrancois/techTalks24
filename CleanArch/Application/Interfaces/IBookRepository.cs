using Domain;

namespace Application.Interfaces;

public interface IBookRepository
{
    List<BookEntity> GetBooks();

    BookEntity GetBook(int id);

    void AddBook(BookEntity book);
}
