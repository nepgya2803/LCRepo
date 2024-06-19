public class Solution
{
    public int MinDays(int[] bloomDay, int m, int k)
    {
        int n = bloomDay.Length;
        if (m * k > n)
        {
            return -1;
        }

        int start = 0;
        int end = 0;
        foreach (int day in bloomDay)
        {
            end = Math.Max(end, day);
        }

        int ans = -1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (GetNumOfBouquets(bloomDay, mid, k) >= m)
            {
                ans = mid;
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return ans;
    }

    private int GetNumOfBouquets(int[] bloomDay, int day, int k)
    {
        int numOfBouquets = 0;
        int flowers = 0;

        foreach (int bloom in bloomDay)
        {
            if (bloom <= day)
            {
                flowers++;
                if (flowers == k)
                {
                    numOfBouquets++;
                    flowers = 0;
                }
            }
            else
            {
                flowers = 0;
            }
        }

        return numOfBouquets;
    }
}