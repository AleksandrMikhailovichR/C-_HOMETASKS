public sealed class Book
{
    public long BookId { get; set; }
    public string BookTitle { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public double PriceUSD { get; set; }
    public BookState State { get; set; } 

}