class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string ISBN { get; set; }
    public string GetBookInfo()
    {
        return $"Title: {Title}, author: {Author}, year: {Year}, ISBN: {ISBN}";
    }
}