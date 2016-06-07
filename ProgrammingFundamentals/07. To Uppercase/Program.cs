using System;

namespace _07.To_Uppercase
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string upcase1 = "<upcase>";
            string upcase2 = "</upcase>";
            string sentenceToUpper;

            for (int i = 0; i < text.Length; i++)
            {
            int up1Index = text.IndexOf(upcase1);
                if (up1Index >= 0)
                {
                    int up2Index = text.IndexOf(upcase2);
                    sentenceToUpper = text.Substring((up1Index + upcase1.Length), up2Index - (up1Index + upcase1.Length)).ToUpper();
                    text = text.Remove(up1Index, (upcase1.Length + sentenceToUpper.Length + upcase2.Length));
                    text = text.Insert(up1Index, sentenceToUpper);
                }
            }
            Console.WriteLine(text);
        }
    }
}
