public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length % groupSize != 0) return false;
        int currentCard = 0;
        Array.Sort(hand);

        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int h in hand)
        {
            if(!dict.ContainsKey(h))
            {
                 dict.Add(h, 1);
                 continue;
            }
            dict[h]++;
        }

        for(int i = 0; i < hand.Length; i++)
        {
            int start = hand[i];
            if(dict[start] == 0) continue;

            for(int y = start; y < start + groupSize; y++)
            {
                dict.TryGetValue(y, out int count);
                {
                    if(count == 0)
                    {
                        return false;
                    }
                }
                dict[y]--;
            }
        }

        return true;
    }
}