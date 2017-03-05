//Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and 
//prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.

// here is an illustration http://www.crazyforcode.com/print-square-matrix-spiral-form/

//here is this solution https://youtu.be/xDsUCkwkVfo


namespace Spiral_Matrix
{
    using System;
    class SpiralMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;

            string direction = "right";
            int maxRotations = n * n;

            for (int i = 1; i <= maxRotations; i++)
            {

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }

                if (direction == "down")
                {
                    row++;
                }

                if (direction == "left")
                {
                    col--;
                }

                if (direction == "up")
                {
                    row--;
                }


                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }

                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }

                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

               

            }

            //type the matrix
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0} ", matrix[r, c]);

                }

                Console.WriteLine();
            }
        }
    }
}
