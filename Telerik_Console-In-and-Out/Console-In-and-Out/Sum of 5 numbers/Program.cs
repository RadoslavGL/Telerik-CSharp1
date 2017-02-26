using System;
class Sumof5numbers
{
    static void Main()
    {
        double inputOne = double.Parse(Console.ReadLine());
        double inputTwo = double.Parse(Console.ReadLine());
        double inputThree = double.Parse(Console.ReadLine());
        double inputFour = double.Parse(Console.ReadLine());
        double inputFive = double.Parse(Console.ReadLine());

        double sumInput = inputOne + inputTwo + inputThree + inputFour + inputFive;
        Console.WriteLine(sumInput);
    }
}

