class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string ISBN { get; set; }
    public Book(string title, string author, int year, string isbn)
    {
        Title = title;
        Author = author;
        Year = year;
        ISBN = isbn;
    }
    public string GetBookInfo()
    {
        return $"Title: {Title}, author: {Author}, year: {Year}, ISBN: {ISBN}";
    }
}