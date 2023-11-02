using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the length of an array:");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[length];
        for (int i = 0; i < length; i++)
        {

            Console.Write("enter elements:");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int middleindex = nums.Length / 2;
        int middlevalue = nums[middleindex];
        Console.WriteLine("the middlevlaue:" + middlevalue);

        Console.WriteLine("left side :");
        for (int i = middleindex - 1; i >= 0; i--)
        {
            Console.Write(nums[i] + "");
        }

        Console.WriteLine("\n right side :");
        for (int i = middleindex + 1; i < length; i++) ;
        {
            int i = 0;
            Console.Write(nums[i] + "");
        }
    }
}