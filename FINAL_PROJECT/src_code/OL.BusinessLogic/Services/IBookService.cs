using OL.DataAccess;

namespace OL.BusinessLogic;

public interface IBookService
{
    bool UpdateBookState(long bookId, BookState newBookState);
}