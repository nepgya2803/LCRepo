public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        List<string> sol = new List<string>();

        for (int i = 0; i < words[0].Length; i++)
        {
            bool isExist = true;
            for (int y = words.Length - 1; y > 0; y--)
            {
                if (!words[y].Contains(words[0][i]))
                {
                    isExist = false;
                    break;
                }
                else
                {
                    int index = words[y].IndexOf(words[0][i]);
                    words[y] = words[y].Remove(index, 1);
                }
            }

            if (isExist)
            {
                sol.Add(words[0][i].ToString());
            }
        }

        return sol;
    }
}