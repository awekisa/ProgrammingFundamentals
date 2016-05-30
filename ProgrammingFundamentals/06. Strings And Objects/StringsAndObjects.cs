using System;


namespace _06.Strings_And_Objects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World";
            object conc = first + " " + second;
            string result = Convert.ToString(conc);
            Console.WriteLine(result);
        }
    }
}
