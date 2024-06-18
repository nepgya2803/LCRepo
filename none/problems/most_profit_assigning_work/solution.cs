public class Solution
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        int maxProfit = 0;
        int index = 0;
        List<(int profits, int diff)> store = new List<(int profits, int diff)>();

        for (int i = 0; i < profit.Length; i++)
        {
            store.Add((profit[i], difficulty[i]));
        }

        store.Sort((a, b) => a.profits - b.profits);

        while (index < worker.Length)
        {
            for (int i = store.Count - 1; i >= 0; i--)
            {
                if (worker[index] >= store[i].diff)
                {
                    maxProfit += store[i].profits;
                    break;
                }
            }

            index++;
        }

        return maxProfit;
    }
}