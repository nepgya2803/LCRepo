public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        if(nums.Length <= 1) return false;

        Dictionary<int, int> cons = new Dictionary<int, int>();
        cons.Add(0, -1);
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum+=nums[i];
            int remainder = sum % k;
            if(cons.ContainsKey(remainder))
            {
                int foundAt = cons[remainder];
                if(i - foundAt >= 2)
                {
                    return true;
                }

                continue;
            }
                cons[remainder] = i;
        }
        

        return false;
    }
}