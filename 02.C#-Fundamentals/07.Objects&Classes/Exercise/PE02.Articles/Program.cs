using System;

namespace PE02.Articles
{
    class Article
    {
        private string title_;
        private string content_;
        private string author_;

        
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;    
            this.Author = author;  
        }

        public string Title
        {
            get => title_;
            set => title_ = value;
        }
        public string Content
        {
            get => content_;
            set => content_ = value;
        }
        public string Author
        {
            get => author_;
            set => author_ = value;
        }

        public void Edit(string content)
        { 
        Content = content;  
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;  
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: { Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] initialArticles = Console.ReadLine ().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(initialArticles[0], initialArticles[1], initialArticles[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                
                string command = input[0];

                switch (command)
                {
                    case "Edit":
                        article.Content = input[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = input[1];  
                        break;
                    case "Rename":
                        article.Rename(input[1]);   
                        break;
                }
            }
            Console.WriteLine(article);

        }
    }


}
