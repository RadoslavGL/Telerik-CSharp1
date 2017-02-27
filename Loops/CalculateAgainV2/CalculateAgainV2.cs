using System;
using System.Numerics;
class CalculateAgainV2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        BigInteger factorialResult = 1;

        for (int i = n; i > k; i--)
        {
            factorialResult *= i;
        }

        Console.WriteLine(factorialResult);
    }
}

