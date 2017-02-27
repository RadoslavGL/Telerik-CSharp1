using System;
using System.Collections.Generic;

class DemoList
{
    static void Main()
    {
        //List<int> list = new List<int> { 100, 200, 300, 400 };

        //for (int i = 0; i < list.Count; i++)
        //{       
        //    int item = list[i];
        //    Console.WriteLine(item);
        //}

        //List<int> list = new List<int> { 100, 200, 300, 400 };

        //foreach (var item in list)
        //{
        //    var item1 = NewMethod(item);
        //    Console.WriteLine(item1);
        //}

        //string[] days = { "Monday", "Tueday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        //foreach (var item in days)
        //{
        //    Console.WriteLine(item);
        //}

        //int n = int.Parse(Console.ReadLine());
        //int m = int.Parse(Console.ReadLine());

        //for (int number = n; number <= m; number++)
        //{
        //    bool prime = true;
        //    int devider = 2;
        //    int maxDevider = (int)Math.Sqrt(m);
        //    while (devider <= maxDevider)
        //    {
        //        if (number % devider == 0)
        //        {
        //            prime = false;
        //            break;
        //        }
        //        devider++;
        //    }
        //    if (prime)
        //    {
        //        Console.Write("{0} ", number);
        //    }

        for (int i = 0; i < 10; i++)
        {
            bool endOfAllLoop = false;
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0} ", j + i);
                if (i + j > 15)
                {
                    endOfAllLoop = true;
                }

                if (endOfAllLoop)
                {
                    break;
                }

            }
            Console.WriteLine();
        }
    }
}



    //private static int NewMethod(int item)
    //{
    //    item += 5;
    //    return item;
    //}


