using OL.DataAccess;

namespace OL.BusinessLogic;

public sealed class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public bool UpdateBookState(long bookId, BookState newBookState)
    {
        return _bookRepository.UpdateBookState(bookId, newBookState);
    }
}