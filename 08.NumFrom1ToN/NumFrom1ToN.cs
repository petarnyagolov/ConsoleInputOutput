﻿using System;

class NumFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

