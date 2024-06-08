
public class Solution
{
    public string ClearDigits(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            res += s[i].ToString();

            if (IsDigit(s[i]))
            {
                res = res.Substring(0, res.Length - 2);
            }
        }

        return res;
    }

    public bool IsDigit(char c)
    {
        return c >= '0' && c <= '9';
    }
}