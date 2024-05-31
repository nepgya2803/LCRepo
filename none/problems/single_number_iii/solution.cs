public class Solution {
    public int[] SingleNumber(int[] nums) {   
        Dictionary<int, int> maps = new Dictionary<int, int>();
        foreach(int num in nums)
        {
            if(maps.ContainsKey(num))
            {
                maps[num]++;
            }
            else
            {
                maps.Add(num, 1);
            }
        }

        List<int> sol = new();
        foreach(var unq in maps)
        {
            if(unq.Value == 1)
            {
                sol.Add(unq.Key);
            }
        }

        return sol.ToArray();
    }
}