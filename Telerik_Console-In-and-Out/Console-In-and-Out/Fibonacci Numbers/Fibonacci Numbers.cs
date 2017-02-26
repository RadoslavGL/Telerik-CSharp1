using System;
class Fibonacci_Numbers
{
    static void Main()
    {
        uint numberOfMembers = uint.Parse(Console.ReadLine());

        long memberOne = 0;
        long memberTwo = 1;
        string sequence = "";

        for (int i = 1; i <= numberOfMembers; i++)
        {
            if (i != numberOfMembers)
            {
                sequence += memberOne;
                sequence += ',';
                sequence += ' ';
            }
            else
            {
                sequence += memberOne;
            }
            long memberNext = memberTwo + memberOne;
            memberOne = memberTwo;
            memberTwo = memberNext;
        }
        Console.WriteLine(sequence);
    }
}

