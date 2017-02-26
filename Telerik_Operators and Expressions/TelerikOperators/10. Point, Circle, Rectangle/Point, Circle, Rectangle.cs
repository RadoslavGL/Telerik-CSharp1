using System;
namespace _10.Point__Circle__Rectangle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //is in circle?
            double circleX = 1; //x of the center of the circle
            double circleY = 1; //y of the center of the circle
            double circleRadius = 1.5; //radius of the circle
            double sideX = Math.Abs(circleX - x); // side of the right triangle parallel to the x line;
            double sideY = Math.Abs(circleY - y); // side of the right triangle parallel to the y line;
            double distancePointCenter = Math.Sqrt(Math.Pow(sideX, 2) + Math.Pow(sideY, 2));

            if (distancePointCenter <= circleRadius)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            //is in rectangle?
            double rectTop = 1; //by description
            double rectLeft = -1; //by description
            double rectWidth = 6; //by description
            double rectHeight = 2; //by description
            bool isInXRange = (x >= rectLeft && x <= rectLeft + rectWidth); // is x within the x-range of the rectangle
            bool isInYRange = (y >= rectTop - rectHeight && y <= rectTop); // is y within the y-range of the rectangle

            if (isInXRange && isInYRange == true)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");

            }

        }
    }
}
