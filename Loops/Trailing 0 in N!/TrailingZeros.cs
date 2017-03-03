//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//Your program should work well for very big numbers, e.g. N = 100000.   

//Time-outs by larger numbers, as the 2nd loops takes too much time; 

using System;
using System.Numerics;
class Trailing0inNFact
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 1; i <= input; i++)
        {
            factorial *= i;

        }

        int zeroCounter = 0;

        while (factorial % 10 == 0)
        {
            if (factorial % 10 == 0)
            {
                zeroCounter++;
            }

            factorial /= 10;

        }

        Console.WriteLine(zeroCounter);
    }
}

