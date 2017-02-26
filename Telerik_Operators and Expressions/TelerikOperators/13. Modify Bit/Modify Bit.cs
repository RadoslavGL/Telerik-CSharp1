using System;
namespace _13.Modify_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            ulong result = 0;

            if (v == 0)
            {
                ulong mask = (ulong)1 << p;
                mask = ~mask;
                result = n & mask;
            }
            else
            {
                ulong mask = (ulong)1 << p;
                result = n | mask;
            }
            Console.WriteLine(result);
        }
    }
}
