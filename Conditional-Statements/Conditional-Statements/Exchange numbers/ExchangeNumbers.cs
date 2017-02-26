using System;
class ExchangeNumbers
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double tempNumber = 0.0;

        if (firstNumber > secondNumber)
        {
            tempNumber = secondNumber;
            secondNumber = firstNumber;
            firstNumber = tempNumber;
        }

        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
    }
}

