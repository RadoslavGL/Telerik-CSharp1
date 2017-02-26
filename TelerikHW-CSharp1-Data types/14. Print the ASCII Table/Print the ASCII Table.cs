using System;
namespace _14.Print_the_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 94; i++)
            {
                Console.WriteLine("{0}", (char)(33 + i));
            }
        }
    }
}
