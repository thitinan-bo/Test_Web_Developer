using find_odd_even;
using System;


class Program
{
    static void Main()
    {
        Function function = new Function();

        for (int i = 1; i <= 100; i++)
        {
            if (function.IsOdd(i))
            {
                Console.WriteLine(i + " >> Odd ");
            }
            else
            {
                Console.WriteLine(i + " >> Even ");
            }

        }

        Console.ReadKey();

    }


}

