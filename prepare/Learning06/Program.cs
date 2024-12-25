
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[] { 1, 2, 4, 5, 6 };
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            nums[i] = sum;
        }

        // Print the cumulative sum array
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }
    }
}
