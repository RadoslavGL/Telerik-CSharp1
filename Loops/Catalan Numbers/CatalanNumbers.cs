using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int userInput = Convert.ToInt32(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger doublefactorial = 1;

        for (int i = 1, j = 1; i <= (2 * userInput); i++)
        {
            doublefactorial *= i;

            while (j <= userInput)
            {
                factorial *= j;
                j++;
            }
        }

        BigInteger result = doublefactorial / (factorial * factorial * (userInput + 1));

        Console.WriteLine(result);
    }
}

