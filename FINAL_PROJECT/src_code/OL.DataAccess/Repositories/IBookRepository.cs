namespace OL.DataAccess;

public interface IBookRepository
{
    bool Create(Book book);
    bool UpdateBookState(long bookId, BookState newBookState);
    int GetBookCount();
    int GetBookCount(BookState bookState);

    ValueTask<bool> CreateAsync(Book book, CancellationToken token = default);
    ValueTask<bool> UpdateBookStateAsync(long orderId, BookState orderState, CancellationToken token = default);
    ValueTask<int> GetBookCountAsync(CancellationToken token = default);
    ValueTask<int> GetBookCountAsync(BookState bookState, CancellationToken token = default);
}
