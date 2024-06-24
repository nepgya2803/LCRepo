public class Solution
{
    public int MinKBitFlips(int[] nums, int k)
    {
        bool[] flipped = Enumerable.Repeat(false, nums.Length).ToArray();
        int validFlipFromPastWindow = 0;
        int flipCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i >= k)
            {
                if (flipped[i - k])
                    validFlipFromPastWindow--;
            }

            if (validFlipFromPastWindow % 2 == nums[i])
            {
                if (i + k > nums.Length)
                {
                    return -1;
                }

                validFlipFromPastWindow++;
                flipped[i] = true;
                flipCount++;
            }
        }
        return flipCount;
    }
}