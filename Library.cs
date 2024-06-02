using System.Dynamic;

class Library
{
    List<Book> Books { get; set; } = new List<Book>();

    public void AddBook(Book book)
    {
        this.
        Books.Add(book);
    }
    public bool RemoveBook(string isbn)
    {
        for (int i = 0; i < Books.Count; i++)
        {
            var item = Books[i];
            if (item.ISBN == isbn)
            {
                Books.RemoveAt(i);
                return true;
            }
        }
        return false;
    }
    public List<Book> FindBooksByTitle(string title)
    {
        var list = new List<Book>();

        // filter
        for (int i = 0; i < Books.Count; i++)
        {
            var item = Books[i];
            if (item.Title.ToLower().Trim().Contains(title.ToLower().Trim()))
            {
                list.Add(item);
            }
        }

        return list;
    }
    public List<Book> FindBooksByAuthor(string author)
    {
        var list = new List<Book>();

        // filter
        for (int i = 0; i < Books.Count; i++)
        {
            var item = Books[i];
            if (item.Author.ToLower().Trim().Contains(author.ToLower().Trim()))
            {
                list.Add(item);
            }
        }

        return list;
    }
    public List<Book> FindBooksByYear(int year)
    {
        var list = new List<Book>();

        // filter
        for (int i = 0; i < Books.Count; i++)
        {
            var item = Books[i];
            if (item.Year == year)
            {
                list.Add(item);
            }
        }

        return list;
    }
}