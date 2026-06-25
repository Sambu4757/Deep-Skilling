using System;

class Program
{
    static void Main()
    {
        Book[] books =
        {
            new Book
            {
                BookId = 1,
                Title = "C#",
                Author = "Microsoft"
            },

            new Book
            {
                BookId = 2,
                Title = "C++",
                Author = "Bjarne Stroustrup"
            },

            new Book
            {
                BookId = 3,
                Title = "Java",
                Author = "James Gosling"
            },

            new Book
            {
                BookId = 4,
                Title = "Python",
                Author = "Guido van Rossum"
            }
        };

        Console.WriteLine("Linear Search:");

        Book? book =
            Search.LinearSearch(books, "Java");

        if (book != null)
        {
            Console.WriteLine(
                $"{book.BookId} " +
                $"{book.Title} " +
                $"{book.Author}");
        }

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        book =
            Search.BinarySearch(books, "Java");

        if (book != null)
        {
            Console.WriteLine(
                $"{book.BookId} " +
                $"{book.Title} " +
                $"{book.Author}");
        }
    }
}