using System;
using System.Numerics;
class CalculateAgain
{
    static void Main()
    {
        BigInteger n = int.Parse(Console.ReadLine());
        BigInteger k = Convert.ToInt32(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        for (BigInteger i = 2, j = 2; i <= n; i++)
        {
            factorialN *= i;

            while (j <= k)
            {
                factorialK *= j;
                j++;

            }
   
        }

        Console.WriteLine(factorialN/factorialK);

    }
}

