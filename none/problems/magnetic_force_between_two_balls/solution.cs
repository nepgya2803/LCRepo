public class Solution
{
    public int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);
        int max = 0;
        int left = 0;
        int right = position.Max(p => p);
        int mid = 0;
        while (left <= right)
        {
            mid = (left + right) / 2;
            if (CanPlace(position, mid, m))
            {
                left = mid + 1;
                max = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return max;
    }

    private bool CanPlace(int[] position, int mid, int m)
    {
        int count = 1;
        int previous = position[0];
        for (int i = 0; i < position.Length; i++)
        {
            if (position[i] - previous >= mid)
            {
                count++;
                previous = position[i];
            }
            if (count == m)
            {
                return true;
            }
        }
        return false;
    }
}