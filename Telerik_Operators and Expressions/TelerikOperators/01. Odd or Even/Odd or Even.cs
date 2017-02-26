using System;
namespace _01.Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("even {0}", n);
            }
            else
            {
                Console.WriteLine("odd {0}", n);
            }
        }
    }
}
