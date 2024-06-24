using System;
namespace BookLibrary
{
    public class Book
    {
        private Title title;
        private Author author;
        private Content content;
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        public Author Author
        {
            get { return author; }
            set { author = value; }
        }
        public Content Content
        {
            get { return content; }
            set { content = value; }
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
