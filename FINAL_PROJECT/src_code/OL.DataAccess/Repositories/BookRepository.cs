namespace OL.DataAccess;

public sealed class BookRepository: IBookRepository
{
    private readonly List<Book> _books;
    private long _id = 0;

    public BookRepository()
    {
        _books = new List<Book>();
    }

    public bool Create(Book book)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> CreateAsync(Book book, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public int GetBookCount() => _books.Count;

    public int GetBookCount(BookState bookState) => _books.Count(b => b.State == bookState);

    public ValueTask<int> GetBookCountAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetBookCountAsync(BookState bookState, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public bool UpdateBookState(long bookId, BookState bookState)
    {
        Book? book = _books.Find(b => b.BookId == bookId);
        if (book is null) return false;

        book.State = bookState;

        return true;
    }

    public ValueTask<bool> UpdateBookStateAsync(long bookId, BookState bookState, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}