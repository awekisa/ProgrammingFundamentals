using System;


namespace _08.Employee_Data
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong id = ulong.Parse(Console.ReadLine());
            uint uniqueNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", secondName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", id);
            Console.WriteLine("Unique Employee number: {0}", uniqueNumber);
        }
    }
}
