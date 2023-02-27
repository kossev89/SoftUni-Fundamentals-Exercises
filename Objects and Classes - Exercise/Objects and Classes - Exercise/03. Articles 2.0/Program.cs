int numberOfArticles = int.Parse(Console.ReadLine());
List<Article> articles = new List<Article>();

for (int i = 0; i < numberOfArticles; i++)
{
    string[] article = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
    string title = article[0];
    string content = article[1];
    string author = article[2];
    Article Article = new Article(title, content, author);
    articles.Add(Article);
    Article.ToString();
}

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

    public void ToString()
    {
        Console.WriteLine($"{Title} - {Content}: {Author}");
    }
}