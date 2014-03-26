using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter: a,b,c.");
        ushort a = ushort.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        string numberBinaryString = Convert.ToString(a, 2).PadLeft(10,'0');
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,10:F3}|", a, numberBinaryString,b,c);
  
    }
}

