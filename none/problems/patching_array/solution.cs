public class Solution
{
    public int MinPatches(int[] nums, int n)
    {
        int patchCount = 0;
        long missing = 1;
        int index = 0;

        while (missing <= n)
        {
            if (index < nums.Length && missing >= nums[index])
            {
                missing += nums[index];
                index++;
            }
            else
            {
                missing *= 2;
                patchCount++;
            }
        }

        return patchCount;

    }
}