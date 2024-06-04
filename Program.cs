// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

class Programm
{
    static void Main(string[] args)
    {
        Library libruary = new Library();
        Console.WriteLine("Добро пожаловать в библиотеку");

        while (true)
        {
            Console.WriteLine("Выбирите действие");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Найти книгу по названию");
            Console.WriteLine("4. Найти книгу по автору");
            Console.WriteLine("5. Найти книгу по году издания");
            Console.WriteLine("6. Показать все книги");
            Console.WriteLine("7. Сохранить библиотеку в файл");
            Console.WriteLine("8. Загрузить библиотеку из файла");
            Console.WriteLine("9. Выйти");
            int chouse = Convert.ToInt32(Console.ReadLine());
            switch (chouse)
            {
                case 1:
                    {
                        Console.Write("Название книги: ");
                        string nBook = Console.ReadLine();
                        Console.Write("Введите автора: ");
                        string author = Console.ReadLine();
                        Console.Write("Введите год издания: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите ISBN: ");
                        string isbn = Console.ReadLine();
                        Book book = new Book(nBook, author, year, isbn);
                        libruary.AddBook(book);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Введите ISBN по которому хотите удалать: ");
                        string isbn = Console.ReadLine();
                        var isRemoved = libruary.RemoveBook(isbn);
                        if (isRemoved == true)
                        {
                            Console.WriteLine("Книга удалена");
                        }
                        else
                        {
                            Console.WriteLine("Книга не удалена");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Write("Введите название по которому хотите найти книгу: ");
                        string title = Console.ReadLine();
                        var list = libruary.FindBooksByTitle(title);
                        ShowBooks(list);
                        break;
                    }
                case 4:
                    {
                        Console.Write("Введите автора по которому хотитие найти книгу: ");
                        string author = Console.ReadLine();
                        var list = libruary.FindBooksByAuthor(author);
                        ShowBooks(list);
                        break;
                    }
                case 5:
                    {
                        Console.Write("Введите год издания книги: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        var list = libruary.FindBooksByYear(year);
                        ShowBooks(list);
                        break;
                    }
                case 6:
                    {
                        var list = libruary.Books;
                        ShowBooks(list);
                        break;
                    }

            }
        }

        static void ShowBooks(List<Book> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Такой книги нет.");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                Console.WriteLine($"{i + 1}. {item.GetBookInfo()}");
            }
        }
    }
}