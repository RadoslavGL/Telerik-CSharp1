using System;
class IntDoubleString
{
    static void Main()
    {
        string type = Console.ReadLine();
        string value = Console.ReadLine();

        if (type == "integer")
        {
            int valueInt = int.Parse(value);
            valueInt += 1;
            Console.WriteLine(valueInt);
        }

        else if (type == "real")
        {
            double valueDouble = double.Parse(value);
            valueDouble += 1;
            Console.WriteLine("{0:0.00}", valueDouble);
        }

        else
        {
            value += '*';
            Console.WriteLine(value);
        }
            
    }
}

