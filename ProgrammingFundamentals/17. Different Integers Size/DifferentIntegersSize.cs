using System;
using System.Collections.Generic;

namespace _17.Different_Integers_Size
{
    class DifferentIntegersSize
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> list = new List<string>();
            try
            {
                sbyte a = sbyte.Parse(input);
                list.Add("sbyte");
            }
            catch (Exception)
            {
            }
            try
            {
                byte a = byte.Parse(input);
                list.Add("byte");
            }
            catch (Exception)
            {
            }
            try
            {
                short a = short.Parse(input);
                list.Add("short");
            }
            catch (Exception)
            {
            }
            try
            {
                ushort a = ushort.Parse(input);
                list.Add("ushort");
            }
            catch (Exception)
            {
            }
            try
            {
                int a = int.Parse(input);
                list.Add("int");
            }
            catch (Exception)
            {
            }
            try
            {
                uint a = uint.Parse(input);
                list.Add("uint");
            }
            catch (Exception)
            {
            }
            try
            {
                long a = long.Parse(input);
                list.Add("long");
            }
            catch (Exception)
            {
            }
            if (list.Count > 0)
            {
                Console.WriteLine("{0} can fit in:", input);

                foreach (var item in list)
                {
                    Console.WriteLine("* " + item);
                }
            }
            else
            {
                Console.WriteLine(input + " can't fit in any type");
            }
        }
    }
}
