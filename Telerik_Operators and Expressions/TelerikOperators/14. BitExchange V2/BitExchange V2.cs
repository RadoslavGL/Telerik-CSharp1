using System;
namespace _14.BitExchange_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            uint mask3 = 7 << 3;
            mask3 = mask3 & number;
            mask3 = mask3 >> 3;

            uint mask24 = 7 << 24;
            mask24 = mask24 & number;
            mask24 = mask24 >> 24;

            uint identify = mask24 ^ mask3;

            uint identify3 = identify << 3;
            number = number ^ identify3;

            uint identify24 = identify << 24;
            number = number ^ identify24;

            Console.WriteLine(number);

        }
    }
}
