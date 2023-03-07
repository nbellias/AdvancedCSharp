using System;
namespace LINQ
{
    public class BookRepository
    {
        private static List<Book> books = new List<Book>();

        public int bookCount()
        {
            return books.Count;
        }

        public void Create(Book book)
        {
            books.Insert(books.Count, book);
        }

        public IEnumerable<Book> RetrieveAll()
        {
            return books;
        }

        public IEnumerable<Book> RetrieveAllByPages(int pages, int countPerPage)
        {
            return books.Skip(pages).Take(countPerPage);
        }

        public Book Retrieve(Guid id)
        {
            return books.Find(book => book.ISBN == id);
        }

        public Book RetrieveByTitle(string title)
        {
            //Check the following with nulls
            //return books.Single(book => book.Title == title);
            return books.SingleOrDefault(book => book.Title == title);
            //return books.First(book => book.Title == title);
            //return books.FirstOrDefault(book => book.Title == title);
            //return books.Last(book => book.Title == title);
            //return books.LastOrDefault(book => book.Title == title);
        }

        public void Update(Guid id, Book newBook)
        {
            var book = Retrieve(id);
            book = newBook;
        }

        public void Remove(Guid id)
        {
            books.Remove(Retrieve(id));

            
        }
    }
}

