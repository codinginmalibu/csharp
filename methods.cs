using System;
using System.Collections.Generic;

public class MyMethods
{
    public static void Main()
    {
        int x = Multiply(5,6);
        Console.WriteLine("x = " + x);

        int y = Divide(39, 13);
        Console.WriteLine("y = " + y);


    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        return a / b;
    }

}
