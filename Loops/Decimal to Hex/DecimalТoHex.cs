using System;
class DecimalТoHex
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string hexValue = "";

        do
        {
            long remainder = input % (long)16;
            switch (remainder)
            {
                case 0: hexValue = "0" + hexValue; break;
                case 1: hexValue = "1" + hexValue; break;
                case 2: hexValue = "2" + hexValue; break;
                case 3: hexValue = "3" + hexValue; break;
                case 4: hexValue = "4" + hexValue; break;
                case 5: hexValue = "5" + hexValue; break;
                case 6: hexValue = "6" + hexValue; break;
                case 7: hexValue = "7" + hexValue; break;
                case 8: hexValue = "8" + hexValue; break;
                case 9: hexValue = "9" + hexValue; break;
                case 10: hexValue = "A" + hexValue; break;
                case 11: hexValue = "B" + hexValue; break;
                case 12: hexValue = "C" + hexValue; break;
                case 13: hexValue = "D" + hexValue; break;
                case 14: hexValue = "E" + hexValue; break;
                case 15: hexValue = "F" + hexValue; break;

            }

            input /= 16;

        } while (input > 0);

        Console.WriteLine(hexValue);
    }
}

