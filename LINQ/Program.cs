// See https://aka.ms/new-console-template for more information
using LINQ;

Console.WriteLine("LINQ");

BookRepository db = new BookRepository();

db.Create(new Book() { ISBN = Guid.NewGuid(), Title = "Brave New World", Price = 5.05f });
db.Create(new Book() { ISBN = Guid.NewGuid(), Title = "The Man and the Sea", Price = 4.80f });
db.Create(new Book() { ISBN = Guid.NewGuid(), Title = "Spare", Price = 9.99f });
db.Create(new Book() { ISBN = Guid.NewGuid(), Title = "ASP.NET MVC Programming", Price = 11.49f });
db.Create(new Book() { ISBN = Guid.NewGuid(), Title = "Little Prince", Price = 12.35f });
db.Create(new Book() { ISBN = Guid.NewGuid(), Title = "C# Paralell Programming", Price = 10.49f });
db.Create(new Book() { ISBN = Guid.NewGuid(), Title = "ASP.NET Core Programming", Price = 10.99f });

Console.WriteLine($"There are {db.bookCount()} books in the database.");

PrintBookTitles(FetchCheapBooks(db));
Console.WriteLine();

//br.Update(br.RetrieveAll().ElementAt<Book>(2).ISBN, new Book() { ISBN = Guid.NewGuid(), Title = "Spare", Price = 10.99f });

PrintBookTitles(AnotherWayFetchCheapBooks(db));
Console.WriteLine();

Pagination(db);
Console.WriteLine();

Console.WriteLine($"The most expensive book has a price of {db.RetrieveAll().Max(b => b.Price)}, " +
    $"the cheapest has a price of {db.RetrieveAll().Min(b => b.Price)}, " +
    $"in a total database price of {db.RetrieveAll().Sum(b => b.Price)}, " +
    $"with an average databsse price of {db.RetrieveAll().Average(b => b.Price)}");

static List<string> FetchCheapBooks(BookRepository br)
{
    //LINQ Extension Methods
    return br.RetrieveAll()
                            .Where(b => b.Price < 10.00f)
                            .OrderBy(b => b.Title)
                            .Select(b => b.Title)
                            .ToList<string>();
}

static List<string> AnotherWayFetchCheapBooks(BookRepository br)
{
    //LINQ Query Operators
    var cheapBooks = from b in br.RetrieveAll()
                     where b.Price < 10.00f
                     orderby b.Title
                     select b.Title;

    return cheapBooks.ToList<string>();
}

static void PrintBooks(List<Book> books)
{
    foreach (var book in books)
    {
        Console.WriteLine($"{book.ISBN} '{book.Title}' {book.Price}");
    }
}

static void PrintBookTitles(List<string> books)
{
    foreach (var book in books)
    {
        Console.WriteLine($"{book}");
    }
}

static void Pagination(BookRepository br)
{
    //Pagination
    var booksPerPage = 2;
    for (int page = 0; page < br.bookCount(); page += booksPerPage)
    {
        PrintBooks(br.RetrieveAllByPages(page, booksPerPage).ToList<Book>());
        Console.WriteLine();
    }
}