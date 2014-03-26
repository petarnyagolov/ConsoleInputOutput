using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter a and b");
        double a = double.Parse(Console.ReadLine());

        double b = double.Parse(Console.ReadLine());
        object comparer;
        comparer = (a > b) ? a : b;
        Console.WriteLine(comparer);

    }
}

