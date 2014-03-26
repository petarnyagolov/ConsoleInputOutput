using System;

class QuadricEquation
{
    static void Main()
        {
            Console.WriteLine("Enter a,b,c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            if (d>0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2*a);
                double x2 = (-b + Math.Sqrt(d)) / (2*a);
                Console.WriteLine("x1={0}; x2={1}",x1,x2);
            }
            else if(d==0)
            {
                double x12=(-b)/(2*a);
                Console.WriteLine("x1=x2={0}",x12);
            }
            else
            {
                Console.WriteLine("No real roots!");
            }
        }
}
    
