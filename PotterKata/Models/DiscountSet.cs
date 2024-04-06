using System;
using System.Linq;
using System.Collections.Generic;

namespace PotterKata.Models;

/// <summary>
/// Represents a set of books in the Potter series with applied discounts.
/// </summary>
public class DiscountSet
{
    private readonly List<Book> _books;
    private readonly Dictionary<int, double> _discounts;

    /// <summary>
    /// The constructor of the DiscountSet class.
    /// </summary>
    public DiscountSet()
    {
        _books = new List<Book>();
        _discounts = new Dictionary<int, double>
        {
            { 1, 1 },
            { 2, 0.95 },
            { 3, 0.9 },
            { 4, 0.8 },
            { 5, 0.75 },
        };
    }

    /// <summary>
    /// Check if the book is already in the set.
    /// </summary>
    /// <param name="book">The book to check</param>
    /// <returns>True if the book is in the set, false otherwise</returns>
    public bool ContainsBook(Book book)
    {
        return _books.Exists(x => x.Volume == book.Volume);
    }

    /// <summary>
    /// Add a book to the set.
    /// </summary>
    /// <param name="book">The book to add</param>
    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    /// <summary>
    /// Remove a book from the set.
    /// </summary>
    /// <param name="book">The book to remove</param>
    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }

    /// <summary>
    /// Calculate the total price of the set.
    /// </summary>
    /// <returns>The total price of the set</returns>
    public double CalculateTotalPrice()
    {
        var discount = _discounts[_books.Count];
        return _books.Sum(x => x.FullPrice) * discount;
    }
}