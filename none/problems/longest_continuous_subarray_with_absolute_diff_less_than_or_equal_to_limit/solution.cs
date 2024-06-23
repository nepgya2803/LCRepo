public class Solution {
    public int LongestSubarray(int[] nums, int limit)
{
    int anchor = 0;
    int mover = anchor;
    int longest = 0;
    PriorityQueue<int, (int, int)> maxQueue = new PriorityQueue<int, (int, int)>(Comparer<(int, int)>.Create((x, y) => y.Item1.CompareTo(x.Item1)));
    PriorityQueue<int, (int, int)> minQueue = new PriorityQueue<int, (int, int)>();

    while (mover < nums.Length)
    {
        maxQueue.Enqueue(mover, (nums[mover], -mover));
        minQueue.Enqueue(mover, (nums[mover], mover));

        while (Math.Abs(nums[maxQueue.Peek()] - nums[minQueue.Peek()]) > limit)
        {
            anchor = int.Min(maxQueue.Peek(), minQueue.Peek()) + 1;
            while (!(minQueue.Peek() >= anchor))
                minQueue.Dequeue();

            while (!(maxQueue.Peek() >= anchor))
                maxQueue.Dequeue();
        }
        longest = int.Max(longest, mover - anchor + 1);
        mover++;
    }
    return longest;
}
}