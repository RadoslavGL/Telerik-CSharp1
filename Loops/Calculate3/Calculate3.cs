using System;
using System.Numerics;
class Calculate3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        //1st part of the furmula - n!/k!;
        BigInteger formulaPartOne = 1;

        //2nd part of the formula - 1/(n - k)! (only the lower part);
        BigInteger formulaPartTwo = 1;

        for (int i = n; i > k; i--)
        {
            formulaPartOne *= i;
        }

        for (int j = 1; j <= n - k; j++)
        {
            formulaPartTwo *= j;
        }

        BigInteger result = formulaPartOne / formulaPartTwo;

        Console.WriteLine(result);


    }
}

