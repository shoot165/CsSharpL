using System;
using BookLibrary;
namespace Pr3
{
    class BookProgram
    {
        static void Main(string[] args)
        {
            Book book = new Book("C# Programming", "John Doe", "This is a comprehensive guide to C# programming.");
            book.Show();
            book.Author.AuthorName = "Jane Doe";
            book.Content.BookContent = "Updated content for the book.";
            book.Show();
        }
    }
}
