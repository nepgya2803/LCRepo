public class Solution {
    public void ReverseString(char[] s)
    {
        var length = s.Count() - 1;
        var midInd = length / 2;
        for (var i = 0; i <= midInd; i++)
        {
            var tmp = s[i];
            s[i] = s[length - i];
            s[length - i] = tmp;
        }
    }
}