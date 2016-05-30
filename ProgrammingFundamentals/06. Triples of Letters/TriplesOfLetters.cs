using System;
using System.Text;

namespace _06.Triples_of_Letters
{
    class TriplesOfLetters
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            char[] combo = new char[3];
            for (int i = 0; i < input; i++)
            {
                char letter = (char)('a' + i);
                combo[0] = letter;              
                for (int b = 0; b < input; b++)
                {
                    char letter2 = (char)('a' + b);
                    combo[1] = letter2;
                    for (int c = 0; c < input; c++)
                    {
                        char letter3 = (char)('a' + c);
                        combo[2] = letter3;
                        foreach (var item in combo)
                        {
                            Console.Write(item);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
