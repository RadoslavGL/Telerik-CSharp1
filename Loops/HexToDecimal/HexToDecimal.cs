using System;
class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        long decimalValue = 0;

        for (int i = 0, j = (input.Length - 1); i < input.Length; i++, j--)
        {
            long multiplier = (long)Math.Pow(16, i);
            switch (input[j])

            // for some reason the input[i] is taking the most left char from the string by i=0, f.ex. with input=FE and i=0 it takes input[i]=input[0]=F
            {
                case '0': decimalValue += 0 * multiplier; break;
                case '1': decimalValue += 1 * multiplier; break;
                case '2': decimalValue += 2 * multiplier; break;
                case '3': decimalValue += 3 * multiplier; break;
                case '4': decimalValue += 4 * multiplier; break;
                case '5': decimalValue += 5 * multiplier; break;
                case '6': decimalValue += 6 * multiplier; break;
                case '7': decimalValue += 7 * multiplier; break;
                case '8': decimalValue += 8 * multiplier; break;
                case '9': decimalValue += 9 * multiplier; break;
                case 'A': decimalValue += 10 * multiplier; break;
                case 'B': decimalValue += 11 * multiplier; break;
                case 'C': decimalValue += 12 * multiplier; break;
                case 'D': decimalValue += 13 * multiplier; break;
                case 'E': decimalValue += 14 * multiplier; break;
                case 'F': decimalValue += 15 * multiplier; break;
            }
        }

        Console.WriteLine(decimalValue);

    }
}

