using System;
using System.Collections.Generic;

public class MyLists
{
    public static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 5, 7 };
        List<int> primeNumbers = new List<int>();
        primeNumbers.AddRange(array);
        primeNumbers.ForEach(item => Console.Write(item + " "));
        Console.WriteLine("\nprimeNumbers count = " + primeNumbers.Count);
    }
}
