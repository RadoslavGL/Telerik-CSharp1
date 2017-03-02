using System;
class Program
{
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(' ');

        long productEven = 1;
        long productOdd = 1;


        for (int i = 0; i < numberOfInputs; i++)
        {
            int value = int.Parse(numbers[i]);

            if ((i + 1) % 2 == 0)
            {
                productEven *= value;
            }

            else
            {
                productOdd *= value;
            }

        }

        if (productEven == productOdd)
        {
            Console.WriteLine("yes {0}", productOdd);
        }

        else
        {
            Console.WriteLine("no {0} {1}", productOdd, productEven);
        }
    }
}

