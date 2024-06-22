class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
            nums[i] = nums[i] % 2 == 0 ? 0 : 1;

        int count = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += nums[i];
            int localSum = sum;
            int index = 0;
            while (index <= i)
            {
                if (localSum == k) count++;
                localSum -= nums[index++];
                if (localSum < k) break;
            }
        }
        return count;
    }
}