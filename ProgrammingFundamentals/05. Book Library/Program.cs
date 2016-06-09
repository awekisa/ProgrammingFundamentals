using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
}
class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
    public decimal Sum { get; set; }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> names = new List<string>();
        List<Library> listLib = new List<Library>();
        List<Book> list = new List<Book>();
        Library library = new Library();
        library.Books = new List<Book>();
        for (int i = 0; i < n; i++)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            Book book = new Book() { Title = arr[0], Author = arr[1], Publisher = arr[2], ReleaseDate = DateTime.ParseExact(arr[3], "dd.MM.yyyy", CultureInfo.InvariantCulture), ISBN = arr[4], Price = decimal.Parse(arr[5]) };
            list.Add(book);

            names.Add(book.Author);
        }
        list = list.OrderBy(e => e.Author).ToList();
        names = names.Distinct().ToList();

        // creating list of libraries
        listLib = listOfLibs(names, listLib);

        // distributing books to libraries
        listLib = distributeBooks(list, listLib);

        // sum prices
        listLib = sumPrices(listLib);
        


        listLib = listLib.OrderBy(e => -e.Sum).OrderBy(s => s.Name).ToList();
        listLib = listLib.OrderBy(e => e.Name).OrderByDescending(e => e.Sum).ToList();

        foreach (var lib in listLib)
        {
            Console.WriteLine("{0} -> {1:f2}", lib.Name, lib.Sum);
        }

    }

    private static List<Library> sumPrices(List<Library> listLib)
    {
        foreach (var lib in listLib)
        {
            decimal sum = 0;
            foreach (var books in lib.Books)
            {
                sum += books.Price;
            }
            lib.Sum = sum;
        }
        return listLib;
    }

    private static List<Library> distributeBooks(List<Book> list, List<Library> listLib)
    {
        foreach (var book in list)
        {
            foreach (var lib in listLib)
            {
                if (book.Author == lib.Name)
                {
                    lib.Books.Add(book);
                }
            }
        }
        return listLib;
    }

    private static List<Library> listOfLibs(List<string> names, List<Library> listLib)
    {
        Library library = new Library();
        foreach (var name in names)
        {
            library = new Library();
            library.Name = name;
            library.Books = new List<Book>();
            listLib.Add(library);
        }
        return listLib;
    }
}




