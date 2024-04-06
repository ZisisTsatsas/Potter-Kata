using PotterKata.Models;

namespace PotterKata.Tests;

public static class ExampleData
{
    public static IEnumerable<object[]> Example1 =>
        new List<object[]>
        {
            new object[]
            {
                "8",
                new List<Book>
                {
                    new(1),
                }
            },
        };

    public static IEnumerable<object[]> Example2 =>
        new List<object[]>
        {
            new object[]
            {
                "15.2",
                new List<Book>
                {
                    new(1),
                    new(2),
                }
            },
        };

    public static IEnumerable<object[]> Example3 =>
        new List<object[]>
        {
            new object[]
            {
                "21.6",
                new List<Book>
                {
                    new(1),
                    new(2),
                    new(3),
                }
            },
        };

    public static IEnumerable<object[]> Example4 =>
        new List<object[]>
        {
            new object[]
            {
                "25.6",
                new List<Book>
                {
                    new(1),
                    new(2),
                    new(3),
                    new(4),
                }
            },
        };

    public static IEnumerable<object[]> Example5 =>
        new List<object[]>
        {
            new object[]
            {
                "30",
                new List<Book>
                {
                    new(1),
                    new(2),
                    new(3),
                    new(4),
                    new(5),
                }
            },
        };

    public static IEnumerable<object[]> Example6 =>
        new List<object[]>
        {
            new object[]
            {
                "23.2",
                new List<Book>
                {
                    new(1),
                    new(2),
                    new(1),
                }
            },
        };

    public static IEnumerable<object[]> Example7 =>
        new List<object[]>
        {
            new object[]
            {
                "30.4",
                new List<Book>
                {
                    new(1),
                    new(2),
                    new(1),
                    new(2),
                }
            },
        };

    public static IEnumerable<object[]> Example8 =>
        new List<object[]>
        {
            new object[]
            {
                "51.2",
                new List<Book>
                {
                    new(1),
                    new(2),
                    new(3),
                    new(4),
                    new(5),
                    new(1),
                    new(2),
                    new(3),
                }
            },
        };
}