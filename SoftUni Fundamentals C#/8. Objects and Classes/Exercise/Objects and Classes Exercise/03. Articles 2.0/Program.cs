using System;
using System.Collections.Generic;
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
            
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main()
        {

            List<Article> articles = new List<Article>();           

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] ArticleStr = Console.ReadLine()
                .Split(", ")
                .ToArray();

                Article article = new Article(ArticleStr[0], ArticleStr[1], ArticleStr[2]);

                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}
