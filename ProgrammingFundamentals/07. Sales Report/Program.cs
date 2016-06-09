using System;
using System.Collections.Generic;

class Sales
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Amount { get; set; }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Sales> SalesNumber = new List<Sales>();
        for (int i = 0; i < n; i++)
        {
            string[] arr = Console.ReadLine().Split();
            Sales sale = new Sales() { Town = arr[0], Product = arr[1], Price = decimal.Parse(arr[2]), Amount = decimal.Parse(arr[3]) };
            SalesNumber.Add(sale);
        }
        SortedDictionary<string, decimal> result = new SortedDictionary<string, decimal>();
        foreach (var sale in SalesNumber)
        {
            if (result.ContainsKey(sale.Town))
            {
                result[sale.Town] += sale.Price * sale.Amount;
            }
            else
            {
                result[sale.Town] = sale.Price * sale.Amount;
            }
        }
        foreach (var entry in result)
        {
            Console.WriteLine("{0} -> {1:f2}", entry.Key, entry.Value);
        }
    }
}

