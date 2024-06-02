public class Solution {
   public int[] TwoSum(int[] nums, int target)
    {
        var maps = new Dictionary<int, int>();
        for (var i = 0; i < nums.Count(); i++)
        {
            var diff = target - nums[i];
            if (maps.ContainsKey(diff))
            {
                return [i, maps[diff]];
            }

            if (!maps.ContainsKey(nums[i])) maps.Add(nums[i], i);
        }

        return [0, 0];
    }
}