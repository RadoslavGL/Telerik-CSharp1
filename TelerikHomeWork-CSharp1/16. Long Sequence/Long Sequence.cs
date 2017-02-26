using System;
namespace _16.Long_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine((1 + i)* Math.Pow( - 1, (1 + i)));
            }
        }
    }
}
