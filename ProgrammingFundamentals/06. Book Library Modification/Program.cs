using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
public string Author { get; set; }
public string Publisher { get; set; }
public DateTime ReleaseDate { get; set; }
public string ISBN { get; set; }
public decimal Price { get; set; }
}

class BookLibraryModification
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Book> list = new List<Book>();
        for (int i = 0; i < n; i++)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            Book book = new Book() { Title = arr[0], Author = arr[1], Publisher = arr[2], ReleaseDate = DateTime.ParseExact(arr[3], "dd.MM.yyyy", CultureInfo.InvariantCulture), ISBN = arr[4], Price = decimal.Parse(arr[5]) };
            list.Add(book);
        }
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        List<Book> result = new List<Book>();
        for (int i = 0; i < n; i++)
        {
            if (date < list[i].ReleaseDate)
            {
                result.Add(list[i]);
            }
        }
        result = result.OrderBy(e => e.Title).OrderBy(e => e.ReleaseDate).ToList();

        foreach (var book in result)
        {
            Console.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Title, book.ReleaseDate);
        }
    }
}

