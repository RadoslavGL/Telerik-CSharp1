using System;
class BiggestOf5v2
{
    static void Main()
    {
        double biggestNumber = double.MinValue;
        for (int i = 1; i <= 5; i++)
        {
            double input = double.Parse(Console.ReadLine());
            if (input >= biggestNumber)
            {
                biggestNumber = input;
            }

        }

        Console.WriteLine(biggestNumber);
    }
}

