﻿using System;


namespace _16.Print_Part_Of_ASCII_Table
{
    class PrintPartOfASCIITable
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
