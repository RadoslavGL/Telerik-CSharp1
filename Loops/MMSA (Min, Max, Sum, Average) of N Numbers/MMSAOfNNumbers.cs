using System;
class MMSAOfNNumbers
{
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());
        int counter = 0;
        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0.0;

        for (int i = 1; i <= numberOfInputs; i++)
        {
            double input = Convert.ToDouble(Console.ReadLine());

            counter++;

            if (input < min)
            {
                min = input;
            }

            if (input > max)
            {
                max = input;
            }

            sum += input;

        }

        Console.WriteLine("min={0:0.00}", min);
        Console.WriteLine("max={0:0.00}", max);
        Console.WriteLine("sum={0:0.00}", sum);
        double average = sum / counter;
        Console.WriteLine("avg={0:0.00}", average);

    }
}

