
/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.
*/

int[] testNums = { 1, 2, 2, 1, 3 };
Console.WriteLine(Solution.SingleNumber(testNums));

public class Solution
{
    static public int SingleNumber(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int element = nums[i];
            if (nums[i] != 0)
            {
                nums[i] = 0;
            }
            else
            {
                nums[i] = 1;
            }

            if (!nums.Contains(element))
            {
                return element;
            }

            nums[i] = element;
        }

        return nums[0]; // if unable to find single number, return first element
    }
}