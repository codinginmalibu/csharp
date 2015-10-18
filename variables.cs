using System;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        int myInt = 1;
        float myFloat = 1f;
        bool myBoolean = true;
        string myName = "John";
        char myChar = 'a';

        System.Console.WriteLine("myInt = " + myInt);
        System.Console.WriteLine("myFloat = " + myFloat);
        System.Console.WriteLine("myBoolean = " + myBoolean);
        System.Console.WriteLine("myName = " + myName);
        System.Console.WriteLine("myChar = " + myChar);
        
		var x = 1;
		var y = 2;
		var sum = x + y;    // sum will also be defined as an integer
        System.Console.WriteLine("x = " + x);
        System.Console.WriteLine("y = " + y);
        System.Console.WriteLine("sum = " + sum);

    }
}
