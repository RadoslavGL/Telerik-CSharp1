using System;
class PlayCard
{
    static void Main()
    {
        string sign = Console.ReadLine();

        switch (sign)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("yes {0}", sign);
                break;
            default:
                Console.WriteLine("no {0}", sign);
                break;
        }

    }
}

