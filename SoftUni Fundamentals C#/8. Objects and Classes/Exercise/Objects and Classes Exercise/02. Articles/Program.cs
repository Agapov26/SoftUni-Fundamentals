using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Author = author;
                Content = content;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public void Edit(string newContent)
            {
                Content = newContent;
            }
            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                Title = newTitle;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main()
        {
            string[] ArticleStr = Console.ReadLine().Split(", ").ToArray();

            Article article = new Article(ArticleStr[0], ArticleStr[1], ArticleStr[2]);

            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}
