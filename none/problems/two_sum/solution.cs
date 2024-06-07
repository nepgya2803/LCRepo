public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         var dictionary = new Dictionary<int, int>();
  for (int i = 0; i < nums.Length; i++)
  {
      int result = target - nums[i];
      if (dictionary.ContainsKey(result))
      {
          return new int[] { dictionary[result],i };
      }
       dictionary[nums[i]] = i;
  }
        throw new ArgumentException("not find target");
    }
}