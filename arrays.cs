using System;
using System.Collections.Generic;

public class Hello
{
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        //Console.WriteLine("array nums = " + nums);
        Console.WriteLine("nums = \n" + string.Join("\n", nums));
        Console.WriteLine("array nums length = " + nums.Length);

        // int[] nums = new int[10];
        int firstNumber = nums[0];
        int secondNumber = nums[1];
        nums[2] = 10;
        Console.WriteLine("firstNumber = " + firstNumber);
        Console.WriteLine("secondNumber = " + secondNumber);
        Console.WriteLine("nums[2] = " + nums[2]);
        Console.WriteLine("nums = \n" + string.Join("\n", nums));


        int[] nums2 = new int[10];
        //Console.WriteLine("array nums2 = " + nums2);
        Console.WriteLine("array nums2 length = \n" + nums2.Length);
        Console.WriteLine("nums2 = " + string.Join("\n", nums2));

        int[,] matrix = new int[2,2];

        matrix[0,0] = 1;
        matrix[0,1] = 2;
        matrix[1,0] = 3;
        matrix[1,1] = 4;

        int[,] predefinedMatrix = new int[2,2] { { 1, 2 }, { 3, 4 } };

    }
}
