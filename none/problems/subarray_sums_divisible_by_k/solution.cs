public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        int size = nums.Length;
        int correctSub = 0;
        int sum = 0;
        if (nums.Length <= 1 && nums[0] % k == 0) 
            return 1;

        Dictionary<int,int> container = new Dictionary<int,int>();
        container.Add(0, 1);

        for(int i = 0; i < nums.Length; i++)
        {
            sum+= nums[i];
            int remainder = sum  % k;
            
            if(remainder < 0)
            {
                remainder += k;
            }

            if(container.ContainsKey(remainder))
            {
                correctSub += container[remainder];
                container[remainder]++;
            }
            else
            {
                container[remainder] = 1;
            }   
        }

        return correctSub;
    }
}