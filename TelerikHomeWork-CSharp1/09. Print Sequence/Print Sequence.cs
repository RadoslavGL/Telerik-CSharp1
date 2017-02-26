using System;
namespace _09.Print_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine((2 + i) * Math.Pow(-1, i));
            }
        }
    }
}
