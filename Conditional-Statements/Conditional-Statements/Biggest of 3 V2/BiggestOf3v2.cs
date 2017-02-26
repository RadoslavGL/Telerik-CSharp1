using System;
class BiggestOf3v2
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            Console.WriteLine(secondNumber);
        }
        else
        {
            Console.WriteLine(thirdNumber);
        }
    }
}

