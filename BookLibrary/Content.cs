using System;
namespace BookLibrary
{
    public class Content
    {
        private string content;
        public string BookContent
        {
            get { return content; }
            set { content = value; }
        }
        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Content: {content}");
            Console.ResetColor();
        }
    }
}
