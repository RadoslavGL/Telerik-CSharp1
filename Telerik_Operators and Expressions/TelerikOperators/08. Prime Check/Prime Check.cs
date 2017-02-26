using System;
namespace _08.Prime_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0 && i != number)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime ? "true": "false");
        }
    }
}
