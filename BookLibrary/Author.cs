using System;
namespace BookLibrary
{
    public class Author
    {
        private string author;
        public string AuthorName
        {
            get { return author; }
            set { author = value; }
        }
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Author: {author}");
            Console.ResetColor();
        }
    }
}
