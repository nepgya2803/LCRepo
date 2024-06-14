public class Solution {
    public void SortColors(int[] nums) {
        int j = 0, k = nums.Length - 1;
        for(int i = 0; i <= k ; i++)
        {
            if(nums[i] == 0)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                j++;
            }

            if(nums[i] == 2)
            {
                (nums[i], nums[k]) = (nums[k], nums[i]);
                i--;
                k--;
            }
        }
    }
}