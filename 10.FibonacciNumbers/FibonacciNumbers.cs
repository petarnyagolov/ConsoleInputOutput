using System;

public static class Fibonachi
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1) Console.WriteLine(0);
        else
        {
            Console.Write("0 ");
            Console.Write("1 ");
            int next = 1;
            for (int i = 2; i < n; i++)
            {
                Console.Write(next + " ");
                next += next;
            }
            Console.WriteLine(next);
        }
    }
}
