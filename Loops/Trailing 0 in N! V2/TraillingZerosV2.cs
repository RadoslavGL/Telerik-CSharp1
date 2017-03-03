//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//Your program should work well for very big numbers, e.g. N = 100000.

//v1 was timing out because of the 2nd loop, which checkes the zeros

//better solution - each multiple of 5 and power of 5 lower or equal to the input means a zero at the end;
//explained here http://www.purplemath.com/modules/factzero.htm

// 5 added as a contant;

namespace TraillingZerosV2
{
    using System;
    using System.Numerics;

    class TraillingZerosV2
    {
        const int five = 5;
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int counter = 0;
            int exponent = 1;

            while (Math.Pow(five, exponent) <= input)
            {
                for (int i = 1; i <= input; i++)
                {
                    int power = (int)Math.Pow(five, exponent);

                    if (i % power == 0)
                    {
                        counter++;
                    }

                }

                exponent++;
            }

            Console.WriteLine(counter);
        }
    }
}
