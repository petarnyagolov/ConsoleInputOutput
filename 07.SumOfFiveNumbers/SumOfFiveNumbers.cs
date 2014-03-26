using System;
using System.Text.RegularExpressions;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter your numbers separate with space");
        string[] input = Console.ReadLine().Split();
        double a = Convert.ToDouble(input[0]);
        double b = Convert.ToDouble(input[1]);
        double c = Convert.ToDouble(input[2]);
        double d = Convert.ToDouble(input[3]);
        double e = Convert.ToDouble(input[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine("Sum is {0}",sum);
    }
}

