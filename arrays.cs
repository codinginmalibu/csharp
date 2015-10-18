using System;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        Console.WriteLine("array nums = " + nums);
        Console.WriteLine("array nums length = " + nums.Length);

        // int[] nums = new int[10];
        int firstNumber = nums[0];
        int secondNumber = nums[1];
        nums[2] = 10;
        Console.WriteLine("firstNumber = " + firstNumber);
        Console.WriteLine("secondNumber = " + secondNumber);
        Console.WriteLine("nums[2] = " + nums[2]);


        int[] nums2 = new int[10];
        Console.WriteLine("array nums2 = " + nums2);
        Console.WriteLine("array nums2 length = " + nums2.Length);

    }
}
