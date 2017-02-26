using System;

class FormattingNumbers
{
    static void Main()
    {
        int inputHexBinar = int.Parse(Console.ReadLine());
        double inputRightAl = double.Parse(Console.ReadLine());
        double inputLeftAl = double.Parse(Console.ReadLine());

        Console.Write(inputHexBinar.ToString("X").PadRight(10, ' '));
        Console.Write('|');
        Console.Write(Convert.ToString(inputHexBinar, 2).PadLeft(10, '0'));
        Console.Write('|');
        Console.Write(inputRightAl.ToString("F").PadLeft(10, ' '));
        Console.Write('|');
        Console.Write(inputLeftAl.ToString("N3").PadRight(10, ' '));
        Console.Write('|');
        Console.WriteLine();

    }
}

