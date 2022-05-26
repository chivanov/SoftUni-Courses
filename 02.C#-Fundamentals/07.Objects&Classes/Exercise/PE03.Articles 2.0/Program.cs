using System;
using System.Linq;
using System.Collections.Generic;

namespace E_03._Articles_2._0
{
    internal class Program
    {
        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                //Console.WriteLine() -> This method is being invoked
                return $"{this.Title} - {this.Content}: {this.Author}";
                //"{title} - {content}: {author}"
            }
        }
        static void Main(string[] args)
        {
            int numOfArcticles = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();
            for (int i = 1; i <= numOfArcticles; i++)
            {
                string[] currArcls = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = currArcls[0];
                string content = currArcls[1];
                string author = currArcls[2];


                Article article = new Article(title, content, author);
                list.Add(article);
            }

            string command = Console.ReadLine();
            if (command == "title" || command == "content" || command == "author")
            {
                foreach (var article in list)
                {
                    Console.WriteLine(article);
                }
            }

        }
    }
}