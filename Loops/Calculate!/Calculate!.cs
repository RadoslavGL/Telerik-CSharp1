using System;
class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());

        double sum = 1;
        double factorial = 1.0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / (Math.Pow(x, i));
        }

        Console.WriteLine(sum.ToString("0.00000"));

    }
}

