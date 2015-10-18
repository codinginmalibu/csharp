using System;
using System.Collections.Generic;

public class MyStrings
{
    public static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";
        int age = 27;
        string sentence = ("{1} {2} is {3} years old.", firstName, lastName, age);
        Console.WriteLine(sentence);
    }
}
