using System;
using System.Collections.Generic;

public class MyDictionary
{
    public static void Main()
    {
        Dictionary<string, long> phonebook = new Dictionary<string, long>();
        phonebook.Add("Alex", 4154346543);
        phonebook["Jessica"] = 4159484588;
        
        if (phonebook.ContainsKey("Alex"))
        {
            Console.WriteLine("Alex's number is " + phonebook["Alex"]);
        }

        phonebook.Remove("Jessica");
        Console.WriteLine(phonebook.Count);
    }
}
