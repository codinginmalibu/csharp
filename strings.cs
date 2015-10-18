using System;
using System.Collections.Generic;

public class MyStrings
{
    public static void Main()
    {
        string myString = "A string.";
        Console.WriteLine("myString = " + myString);

        String myStringObj = "A string.";
        Console.WriteLine("myStringObj object = " + myStringObj);

        string emptyString = String.Empty;
        Console.WriteLine("emptyString = " + emptyString);

        string anotherEmptyString = "";
        Console.WriteLine("anotherEmptyString = " + anotherEmptyString);

        string firstName = "Eric";
        string lastName = "Smith";
        string fullName = firstName + " " + lastName;
        Console.WriteLine("fullName = " + fullName);

        string sentence = "I like to play ";
        sentence += "chess.";
        Console.WriteLine("sentence = " + sentence);

        int x = 1, y = 2;
        int sum = x + y;
        string sumCalculation = String.Format("{0} + {1} = {2}", x, y, sum);
        Console.WriteLine(sumCalculation);

        string fullString = "full string";
        string partOfString = fullString.Substring(5);
        string shorterPart = fullString.Substring(5, 3);
        Console.WriteLine("partOfString = " + partOfString);
        Console.WriteLine("shorterPart = " + shorterPart);

        string name = "John Doe";
        Console.WriteLine("name = " + name);
        string newName = name.Replace("John", "Eric");
        Console.WriteLine("newName = " + newName);
        
        string fruit = "apple,orange,banana";
        Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange"));
        Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon"));

    }
}
