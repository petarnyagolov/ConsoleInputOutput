using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter n");
            double n = int.Parse(Console.ReadLine());
            double sum=0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number");
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }

