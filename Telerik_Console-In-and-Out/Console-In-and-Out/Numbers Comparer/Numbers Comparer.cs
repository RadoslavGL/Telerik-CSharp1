using System;
class Program
{
    static void Main(string[] args)
    {
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());

        if (numberOne > numberTwo)
        {
            Console.WriteLine(numberOne);
        }
        else
        {
            Console.WriteLine(numberTwo);
        }
    }
}
