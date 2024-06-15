public class Solution
{
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
    {
        int resProfit = w;
        int cnt = 0;
        List<(int profit, int cap)> store = new List<(int, int)>();
        for (int i = 0; i < profits.Length; i++)
        {
            store.Add((profits[i], capital[i]));
        }

        int waitIndex = 0;
        store.Sort((a, b) => a.cap.CompareTo(b.cap));
        PriorityQueue<int, int> pQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

        while (cnt < k)
        {
            while (waitIndex < store.Count && resProfit >= store[waitIndex].cap)
            {
                pQueue.Enqueue(store[waitIndex].profit, store[waitIndex].profit);
                waitIndex++;
            }
            if (pQueue.TryDequeue(out var profit, out var cap))
            {
                resProfit += profit;
                cnt++;
            }
            else
            {
                return resProfit;
            }
        }

        return resProfit;
    }
}