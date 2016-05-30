using System;

public class Substring
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';
        bool hasMatch = false;
        char[] compare = text.ToCharArray();
        string matchedString;

        for (int i = 0; i < text.Length; i++)
        {
            if (compare[i] == Search)
            {
                hasMatch = true;

                int endIndex = jump;

                if (endIndex + i >= text.Length)
                {
                    matchedString = text.Substring(i);
                    Console.WriteLine(matchedString);
                    break;
                }

                matchedString = text.Substring(i, endIndex+1);
                Console.WriteLine(matchedString);
                i += endIndex;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
