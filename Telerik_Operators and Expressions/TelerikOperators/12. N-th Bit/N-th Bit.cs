using System;
namespace _12.N_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            ulong p = ulong.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            ulong pRestriction = (ulong)Math.Pow(2, 55);
            if ((n < 55) && (p <= pRestriction))
            {
                ulong mask = p >> n;
                ulong result = mask & 1;
                Console.WriteLine(result == 0 ? "0":"1");
            }

        }
    }
}
