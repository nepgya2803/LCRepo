public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char, int> maps = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(maps.ContainsKey(c))
            {
                maps[c]++;
            }
            else
            {
                maps.Add(c, 1);
            }
        }

        int result = 0;
        int odd = 0;
        foreach(var pair in maps)
        {
            if(pair.Value % 2 == 0)
            {
                result += pair.Value;
            }
            else
            {
                result += (pair.Value - 1);
                odd = 1;
            }
        }

        return result + odd;
    }
}