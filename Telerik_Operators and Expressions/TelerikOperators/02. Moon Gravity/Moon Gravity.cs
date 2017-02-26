using System;
namespace _02.Moon_Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double moonWeight = w * 0.17;
            Console.WriteLine("{0:f3}", moonWeight);
        }
    }
}
