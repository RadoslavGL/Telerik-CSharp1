﻿using System;
class Circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * r * Math.PI;
        double area = r * r * Math.PI;

        Console.WriteLine("{0:f2} {1:f2}", perimeter, area);
    }
}

