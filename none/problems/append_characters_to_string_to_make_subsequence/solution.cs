public class Solution {
    public int AppendCharacters(string s, string t) {
        int indT = 0, indS = 0;
        while(indS < s.Length && indT < t.Length)
        {
            if(s[indS++] == t[indT])
            {
                indT++;
            }
        }

        return t.Length - indT;
    }
}