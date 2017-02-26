using System;
class Interval
{
    static void Main()
    {
        int lowerBreak = int.Parse(Console.ReadLine());
        int upperBreak = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = (lowerBreak + 1); i < upperBreak; i++)
        {
            if (i % 5 == 0)
            {
                counter += 1;
            }
        }
        Console.WriteLine(counter);
    } 
}

