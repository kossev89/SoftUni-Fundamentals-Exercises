string[] article = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
int numberOfCommands = int.Parse(Console.ReadLine());
string title = article[0];
string content = article[1];
string author = article[2];
Article Article = new Article(title, content, author);

for (int i = 0; i < numberOfCommands; i++)
{
    string[] command = Console.ReadLine()
        .Split(": ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string operation = command[0];
    string action = command[1];
    if (operation == "Edit")
    {
        Article.Edit(operation, action);
    }
    else if (operation == "ChangeAuthor")
    {
        Article.ChangeAuthor(operation, action);
    }
    else if (operation == "Rename")
    {
        Article.Rename(operation, action);
    }
}
Article.ToString();

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

    public void Edit(string operation, string action)
    {
        Content = action;
    }
    public void ChangeAuthor(string operation, string action)
    {
        Author = action;
    }
    public void Rename(string operation, string action)
    {
        Title = action;
    }
    public void ToString()
    {
        Console.WriteLine($"{Title} - {Content}: {Author}");
    }
}