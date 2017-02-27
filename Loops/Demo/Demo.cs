using System;
using System.Numerics;
class Demo
{
    static void Main()
    {
        //int counter = 0;
        //while (counter < 10)
        //{
        //    Console.WriteLine("number: {0}", counter);
        //    counter++;
        //}

        //uint input = uint.Parse(Console.ReadLine());
        //uint devider = 2;
        //uint maxDevider = (uint)Math.Sqrt(input);
        //bool prime = true;

        //while (prime && devider <= maxDevider)
        //{
        //    if (input % devider == 0)
        //    {
        //        prime = false;
        //    }

        //    devider++;
        //}

        //Console.WriteLine("Prime? {0}", prime);

        //uint n = Convert.ToUInt32(Console.ReadLine());
        //uint fact = 1;

        //while (true)
        //{
        //    Console.Write(n);
        //    if (n == 1)
        //    {
        //        break;
        //    }

        //    fact *= n;
        //    n--;
        //    Console.Write(" * ");

        //}

        //Console.WriteLine(" = {0}",fact);


        //string userInput = Console.ReadLine();
        //int n = Convert.ToInt32(userInput);

        //BigInteger factorial = 1;

        //do
        //{
        //    factorial *= n;
        //    n--;


        //} while (n > 0);

        //Console.WriteLine("n! = {0}", factorial);

        //    int smallerNumber = int.Parse(Console.ReadLine());
        //    int biggerNumber = int.Parse(Console.ReadLine());

        //    int min = Math.Min(smallerNumber, biggerNumber);
        //    int max = Math.Max(biggerNumber, smallerNumber);

        //    smallerNumber = min;
        //    biggerNumber = max;

        //    decimal product = 1;
        //    int multiplyer = smallerNumber;

        //    do
        //    {
        //        product *= multiplyer;
        //        multiplyer++;

        //    } while (multiplyer <= biggerNumber);

        //    Console.WriteLine("product [smaller number ... bigger number] = {0}", product);

        //for (int i = 1, sum = 1; i <= 128; i = i*2, sum += i)
        //{
        //    Console.WriteLine("i = {0}, sum = {1}", i, sum);
        //}

        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i += 2)
        {
            if (n % 7 == 0)
            {
                continue;
            }

            sum = sum + i;
        }

        Console.WriteLine("sum = " + sum);

    }
}

