using System;
using System.Collections.Generic;

public class MyLoops
{
    public static void Main()
    {
        for(int i = 0; i < 16; i++)
        {
            if(i == 12)
            {
                break;    
            }
            Console.WriteLine("loop i = " + i);
        }
        for(int i = 0; i < 16; i++)
        {
            if(i % 2 == 1)
            {
                continue;
            }
            Console.WriteLine("loop 2 i = " + i);
        }

        string x = "Hi";
        int n = 10;

        // write for loop here
        for (int y = 0; y < n; y++)
        {
            Console.WriteLine(x);
        }

        // while loop
        int n = 0;
        while( n == 0)
        {
            Console.WriteLine("n is 0");
            n++;
        }

        // foreach loop
        string[] names = {"Cheryl", "Joe", "Matt", "Robert"};

        foreach (string person in names)
        {
            Console.WriteLine("{0} ", person);
        }

    }
}
