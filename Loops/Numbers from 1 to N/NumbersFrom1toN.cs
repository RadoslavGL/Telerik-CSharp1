using System;
class NumbersFrom1toN
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());

        Console.Write("1");
        for (int i = 2; i <= input; i++)
        {
            Console.Write(" {0}", i);
        }
        Console.WriteLine();
    }
}
