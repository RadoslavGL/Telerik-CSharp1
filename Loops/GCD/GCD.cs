using System;
class GCD
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int firstNumber = int.Parse(input[0]);
        int secondNumber = int.Parse(input[1]);

        int largerValue = Math.Max(firstNumber, secondNumber);
        int smallerValue = Math.Min(firstNumber, secondNumber);

        do
        {
            int tempValue = largerValue % smallerValue;
            largerValue = smallerValue; // GCD
            smallerValue = tempValue;

        } while (smallerValue != 0);

        Console.WriteLine(largerValue);
    }
}

