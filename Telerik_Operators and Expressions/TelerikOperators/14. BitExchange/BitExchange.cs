using System;
namespace _14.BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());

            int positionsMoved1 = 21; // positions from 3, 4, 5 to 24, 25, 26;
            //int positionsMoved2 = 27; // positions from 0, 1, 2, 3 to 27, 28, 29, 30;

            //mask for bits 3, 4, 5 -> positions 24, 25, 26
            ulong mask1 = number << positionsMoved1; // moves bits 3, 4, 5 -> positions 24, 25, 26
            ulong removal = (ulong)7 << (positionsMoved1 + 3);
            mask1 = mask1 & removal;

            //mask for bits 24, 25, 26 -> positions 3, 4, 5
            ulong mask2 = number >> positionsMoved1; // moves bits 24, 25, 26 -> positions 3, 4, 5
            removal = removal >> (positionsMoved1);
            mask2 = mask2 & removal;

            // mask that has 0 in positions 3, 4, 5 and 24, 25, 26 and 1 everwhere else;
            int mask3 = 7 << positionsMoved1;
            mask3 = mask3 + 7;
            mask3 = mask3 << 3;
            mask3 = ~mask3;

            //applying mask3
            number = number & (ulong)mask3;

            //applying mask1 and mask2 that and exchanging the bits;
            number = number | mask1;
            number = number | mask2;


            Console.WriteLine(number);

            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            //Console.WriteLine(Convert.ToString(mask1, 2).PadLeft(32, '0'));
            //Console.WriteLine(Convert.ToString(mask2, 2).PadLeft(32, '0'));
            //Console.WriteLine(Convert.ToString(mask3, 2).PadLeft(32, '0'));

        }
    }
}
