// See https://aka.ms/new-console-template for more information

using PotterKata.Models;
using PotterKata.Services;

namespace PotterKata;

public abstract class Program
{
    public static void Main(string[] args)
    {
        var basket = new List<Book>
        {
            new(1),
            new(2),
            new(3),
            new(4),
            new(5),
            new(1),
            new(2),
            new(3),
        };
        var discountsService = new DiscountsService();
        var discountedPrice = discountsService.GetDiscountForBasket(basket);

        Console.WriteLine($"Total Price: {discountedPrice}");
    }
}