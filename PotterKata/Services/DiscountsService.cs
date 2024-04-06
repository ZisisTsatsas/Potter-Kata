using PotterKata.Models;

namespace PotterKata.Services;

/// <summary>
/// Represents a service that calculates the discounts for a basket of books.
/// </summary>
public class DiscountsService
{
    private readonly List<DiscountSet> _discountSets = [];

    /// <summary>
    /// Get the total price of the basket after applying the discount
    /// </summary>
    /// <param name="basket">The basket containing the Potter books</param>
    /// <returns>The total price after discount</returns>
    public double GetDiscountForBasket(List<Book> basket)
    {
        basket = basket.OrderBy(x => x.Volume).ToList();
        foreach (var book in basket)
        {
            if (!TryAddToExistingSet(book))
            {
                var discountSet = new DiscountSet();
                discountSet.AddBook(book);
                _discountSets.Add(discountSet);
            }
        }

        return GetTotalPrice();
    }

    /// <summary>
    /// Try to add the book to an existing set by checking the set price.
    /// </summary>
    /// <param name="book">The book to add</param>
    /// <returns>True if the book was added to an existing set, false otherwise</returns>
    private bool TryAddToExistingSet(Book book)
    {
        var availableDiscountSets = _discountSets.Where(x => !x.ContainsBook(book)).ToList();
        if (availableDiscountSets.Count == 0)
        {
            return false;
        }

        var minPrice = availableDiscountSets.Min(discountSet => GetTotalPriceAfterAdding(discountSet, book));
        var bestDiscountSet = availableDiscountSets.First(discountSet => GetTotalPriceAfterAdding(discountSet, book).Equals(minPrice));

        bestDiscountSet.AddBook(book);
        return true;
    }

    private double GetTotalPriceAfterAdding(DiscountSet discountSet, Book book)
    {
        discountSet.AddBook(book);
        var totalPrice = GetTotalPrice();
        discountSet.RemoveBook(book);
        return totalPrice;
    }

    private double GetTotalPrice()
    {
        return _discountSets.Sum(x => x.CalculateTotalPrice());
    }
}