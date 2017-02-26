using System;
namespace _07.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (radius <= 2)
            {
                Console.WriteLine("yes {0:f2}", radius);
            }
            else
            {
                Console.WriteLine("no {0:f2}", radius);
            }
        }
    }
}
