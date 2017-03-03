//Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and 
//prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.

// here is an illustration http://www.crazyforcode.com/print-square-matrix-spiral-form/


namespace Spiral_Matrix
{
    using System;
    class SpiralMatrix
    {
        static void Main()
        {
            int sideLength = int.Parse(Console.ReadLine());
            int value = 1;

            for (int i = 1; i <= sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write("{0} ", value);
                    value++;
                }

                Console.WriteLine();

            }
        }
    }
}
