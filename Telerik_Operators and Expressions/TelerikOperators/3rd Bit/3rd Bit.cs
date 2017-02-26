using System;
namespace _3rd_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            //Console.WriteLine(Convert.ToString(mask, 2));
            int maskAndNumber = number & mask;
            //Console.WriteLine(Convert.ToString(maskAndNumber, 2));
            int bit = maskAndNumber >> 3;
            Console.WriteLine(bit);
        }
    }
}
