using System;
class NotDivisibleNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Console.Write("1");

        for (int i = 2; i <= input; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(" {0}", i);
            }
        }

        Console.WriteLine();

    }
}

