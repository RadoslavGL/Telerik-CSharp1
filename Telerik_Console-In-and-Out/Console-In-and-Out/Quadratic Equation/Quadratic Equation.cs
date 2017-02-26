using System;
class QuadraticEquation
{
    static void Main()
    {
        double indexA = double.Parse(Console.ReadLine());
        double indexB = double.Parse(Console.ReadLine());
        double indexC = double.Parse(Console.ReadLine());

        double discriminant = Math.Sqrt(Math.Pow(indexB, 2) - 4 * indexA * indexC);

        if (discriminant == 0)
        {
            double singleRoot = ((-1) * indexB) / (2 * indexA);
            Console.WriteLine(singleRoot.ToString("0.00"));
        }
        else if (discriminant > 0)
        {
            double rootOne = (((-1) * indexB) - discriminant) / (2 * indexA);
            Console.WriteLine(rootOne.ToString("0.00"));

            double rootTwo = (((-1) * indexB) + discriminant) / (2 * indexA);
            Console.WriteLine(rootTwo.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}

