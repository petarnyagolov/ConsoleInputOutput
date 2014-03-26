using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        
        Console.WriteLine("Please, enter r");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r,2);

        Console.WriteLine("Perimeter is {0:0.00}, area is {1:0.00}",perimeter,area);

    }
}
    

