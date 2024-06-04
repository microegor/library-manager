using System.Dynamic;

class Library
{
    public List<Book> Books { get; set; } = new List<Book>()
    {
        new Book("Book1", "author1", 1961, "isbn1"),
        new Book("Book2", "author2", 1952, "isbn2"),
        new Book("Book3", "author2", 2021, "isbn3"),
    };

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