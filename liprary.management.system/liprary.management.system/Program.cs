
namespace liprary.management.system
{
    class Library
    {
        public List<Book> books { get; set; } = new();
        internal void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"the book {book.Title} is added ");
        }
        public void BorrowBook(string name)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Contains(name))
                {
                    books[i].Avaabilability = false;
                    Console.WriteLine("the book is here u can take it ");
                }
                else
                    Console.WriteLine("the book is not here ");
            }
        }
        internal void ReturnBook(string name)
        {
            foreach (var item in books)
            {
                if (item.Title.Contains(name))
                {
                    item.Avaabilability = true;
                    Console.WriteLine("okay thanks ");
                }
                else
                    Console.WriteLine($"This book {item.Title}is not borrowed ");
            }
        }
    }
    class Book
    {
        public Book(string title, string author, string asbn, bool avaabilability = true)
        {
            Title = title;
            Author = author;
            Asbn = asbn;
            Avaabilability = avaabilability;
            List<Book> books = new();
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Asbn { get; set; }
        public bool Avaabilability { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

           
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

           
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter");

          
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter");


            Console.ReadLine();

        }
    }
}
