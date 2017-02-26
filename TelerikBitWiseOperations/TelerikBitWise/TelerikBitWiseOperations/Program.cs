using System;
namespace TelerikBitWiseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //ushort a = 3;
            //ushort b = 5;

            //Console.WriteLine(a | b);
            //Console.WriteLine(a & b);
            //Console.WriteLine(a ^ b);
            //Console.WriteLine(~a & b);
            //Console.WriteLine(a << 1);
            //Console.WriteLine(a >> 1);

            ////Mask for p-position bit;
            //int p = 5;
            //int n = 35;
            //int mask = 1 << p;
            //int nAndMask = n & mask;
            //int bit = nAndMask >> p;
            //Console.WriteLine(bit);

            ////Set the bit at p-position to 0;
            //int p = 5;
            //int n = 35;
            //int mask = ~(1 << p);
            //int result = n & mask;
            //Console.WriteLine(result);

            //Set the bit at p-position to 1;
            int p = 4;
            int n = 35;
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            int mask = 1 << p;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            int result = n | mask;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));


        }
    }
}
