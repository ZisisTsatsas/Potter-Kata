namespace PotterKata.Models;

/// <summary>
/// Represents a book in the Potter series.
/// </summary>
public class Book
{
    /// <summary>
    /// The constructor of the Book class.
    /// </summary>
    /// <param name="volume">The volume number of the book in the series</param>
    /// <param name="fullPrice">The retail price of the book</param>
    public Book(int volume, double fullPrice = 8)
    {
        Volume = volume;
        FullPrice = fullPrice;
    }

    /// <summary>
    /// The price of the book.
    /// </summary>
    public double FullPrice { get; set; }

    /// <summary>
    /// The volume number of the Book.
    /// </summary>
    public int Volume { get; set; }
}