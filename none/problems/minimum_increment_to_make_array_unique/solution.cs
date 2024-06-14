public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        Array.Sort(nums);
        int result = 0;
        for(int i = 1; i < nums.Length; i++)
        {
           if (nums[i] <= nums[i - 1])
            {
                int diff = nums[i - 1] - nums[i] + 1;
                result += diff;
                nums[i] += diff;
            }
        }

        return result;
    }
}