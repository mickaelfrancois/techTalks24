using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class BookRepository : IBookRepository
{
    private List<BookEntity> _books = [
             new BookEntity { Id = 1, Title = "Dune" },
             new BookEntity { Id = 2, Title = "L'alchimiste" },
             new BookEntity { Id = 3, Title = "Le seigneur des anneaux" },
             new BookEntity { Id = 4, Title = "Harry Potter" },
             new BookEntity { Id = 5, Title = "Le meilleur des mondes" }
             ];

    public BookEntity GetBook(int id)
    {
        return GetBooks().Where(x => x.Id == id).FirstOrDefault();
    }

    public List<BookEntity> GetBooks()
    {
        return _books;
    }

    public void AddBook(BookEntity book)
    {
        book.Id = _books.Count() + 1;
        _books.Add(book);
    }
}
