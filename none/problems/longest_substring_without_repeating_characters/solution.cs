public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;

        var subString = "";
        var stringCollect = new List<string>();
        for(var i = 0; i < s.Length; i++)
        {
            var index = subString.IndexOf(s[i]);
            if (index == -1)
            {
                subString += s[i];
            }
            else
            {
                stringCollect.Add(subString);
                subString = subString.Substring(index + 1);
                subString += s[i];
            }

            if (i == s.Length - 1)
                stringCollect.Add(subString);
        }

        return stringCollect.Max(x => x.Length);
    }
}