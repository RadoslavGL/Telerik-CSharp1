using System;
class SumofNNumbers
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        double sumInput = 0.0;
        for (int i = 1; i <= inputNumber; i++)
        {
            double inputValue = double.Parse(Console.ReadLine());
            sumInput += inputValue;
        }
        Console.WriteLine(sumInput);
    }
}

