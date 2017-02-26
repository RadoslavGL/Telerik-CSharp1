using System;
class BiggestOf3
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double biggestNumber = double.MinValue;

        if (firstNumber > biggestNumber)
        {
            biggestNumber = firstNumber;
        }

        if (secondNumber > biggestNumber)
        {
            biggestNumber = secondNumber;
        }

        if (thirdNumber > biggestNumber)
        {
            biggestNumber = thirdNumber;
        }

        Console.WriteLine(biggestNumber);
       
        
    }
}

