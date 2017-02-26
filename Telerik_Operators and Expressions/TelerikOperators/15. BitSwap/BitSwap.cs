using System;
namespace _15.BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            uint maskP = (uint)(Math.Pow(2, k) - 1) << p;
            maskP = maskP & n;
            maskP = maskP >> p;

            uint maskQ = (uint)(Math.Pow(2, k) - 1) << q;
            maskQ = maskQ & n;
            maskQ = maskQ >> q;

            uint identify = maskP ^ maskQ;

            uint identifyQ = identify << q;
            n = n ^ identifyQ;

            uint identifyP = identify << p;
            n = n ^ identifyP;

            Console.WriteLine(n);


        }
    }
}
