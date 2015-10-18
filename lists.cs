using System;
using System.Collections.Generic;

public class MyLists
{
    public static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        // Console.WriteLine("list numbers = " + numbers);
        numbers.ForEach(Console.WriteLine);
        numbers.ForEach(item => Console.Write(item + " "));

        List<int> numbers2 = new List<int>();
        int[] array = new int[] { 1, 2, 3 };
        numbers2.AddRange(array);
        numbers2.ForEach(item => Console.Write(item + " "));

        List<string> fruits = new List<string>();
        // add fruits
        fruits.Add("apple");
        fruits.Add("banana");
        fruits.Add("orange");
        Console.WriteLine("\nfruits count = " + fruits.Count);
        fruits.ForEach(item => Console.Write(item + " "));

        // now remove the banana
        fruits.Remove("banana");
        Console.WriteLine("\nfruits count = " + fruits.Count);
        fruits.ForEach(item => Console.Write(item + " "));

        // now remove the another
        fruits.RemoveAt(1);
        Console.WriteLine("\nfruits count = " + fruits.Count);
        fruits.ForEach(item => Console.Write(item + " "));

        List<string> food = new List<string>();
        food.Add("apple");
        food.Add("banana");
        Console.WriteLine("\nfood count = " + food.Count);

        List<string> vegetables = new List<string>();
        vegetables.Add("tomato");
        vegetables.Add("carrot");
        Console.WriteLine("\nvegetables count = " + vegetables.Count);

        food.AddRange(vegetables);
        Console.WriteLine("\nfood count = " + food.Count);
    }
}
