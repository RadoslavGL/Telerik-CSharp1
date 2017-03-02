using System;
class DecimalToBinary
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());

        string binaryValue = "";

        do
        {
            if (input % 2 == 1)
            {
                binaryValue = "1" + binaryValue;
            }

            else
            {
                binaryValue = "0" + binaryValue;
            }

            input /= 2;

        } while (input != 0);

        Console.WriteLine(binaryValue);
    }
}

