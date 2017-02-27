using System;
class PrintADeck
{
    static void Main()
    {
        string face = Console.ReadLine();

        if (face != "J" && face != "Q" && face != "K" && face != "A")
        {
            int faceNumber = int.Parse(face);
            for (int i = 2; i <= faceNumber; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }

        }

        else
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }

            if (face == "J")
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", face);
            }

            else if (face == "Q")
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", face);
            }

            else if (face == "K")
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", face);
            }

            else
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", face);
            }

        }

    }
}

