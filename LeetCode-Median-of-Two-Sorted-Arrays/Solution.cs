namespace LeetCode_Median_of_Two_Sorted_Arrays;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> nums = new List<int>(nums1);
        nums.AddRange(nums2);
        nums.Sort();
        return nums.Count % 2 == 0 ? (nums[nums.Count / 2 - 1] + nums[nums.Count / 2]) / 2.0 : nums[nums.Count / 2];
    }
}