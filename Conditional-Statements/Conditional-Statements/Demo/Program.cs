﻿using System;
class Demo
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int biggerNumber = firstNumber;

        if (secondNumber > firstNumber)
        {
            biggerNumber = secondNumber;
        }
        Console.WriteLine(biggerNumber);
    }
}
