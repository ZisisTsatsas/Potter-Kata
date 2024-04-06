using System.Globalization;
using PotterKata.Models;
using PotterKata.Services;
using FluentAssertions;

namespace PotterKata.Tests;

public class DiscountServiceTests
{
    [Theory]
    [MemberData(nameof(ExampleData.Example1), MemberType = typeof(ExampleData))]
    [MemberData(nameof(ExampleData.Example2), MemberType = typeof(ExampleData))]
    [MemberData(nameof(ExampleData.Example3), MemberType = typeof(ExampleData))]
    [MemberData(nameof(ExampleData.Example4), MemberType = typeof(ExampleData))]
    [MemberData(nameof(ExampleData.Example5), MemberType = typeof(ExampleData))]
    [MemberData(nameof(ExampleData.Example6), MemberType = typeof(ExampleData))]
    [MemberData(nameof(ExampleData.Example7), MemberType = typeof(ExampleData))]
    [MemberData(nameof(ExampleData.Example8), MemberType = typeof(ExampleData))]
    public void Total_ShouldEqual(string expected, List<Book> basket)
    {
        var discountsService = new DiscountsService();
        var actual = discountsService.GetDiscountForBasket(basket).ToString(CultureInfo.InvariantCulture);
        actual.Should().Be(expected);
    }
}