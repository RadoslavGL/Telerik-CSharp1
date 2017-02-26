using System;
namespace _13.Comparing_Floats
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            double diff = 0.000001;

            if (Math.Max(a, b) - Math.Min(a, b) < diff)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
