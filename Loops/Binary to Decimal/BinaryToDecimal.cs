using System;
using System.Numerics;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        BigInteger binaryValue = BigInteger.Parse(input);
        BigInteger decimalValue = 0;

        for (int i = 0; i < input.Length; i++)
        {
            BigInteger tempValue = binaryValue % 10;
            decimalValue += tempValue * (BigInteger) Math.Pow(2, i);
            binaryValue /= 10;
        }

        Console.WriteLine(decimalValue);
    }
}

