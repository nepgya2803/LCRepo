class Solution
{
    public:
        int maximumGain(std::string s, int x, int y)
        {
            int result = 0;
            std::string highPrio = x > y ? "ab" : "ba";
            std::string lowPrio = x < y ? "ab" : "ba";
            int highScore = std::max(x, y);
            int lowScore = std::min(x, y);
            std::string currentStr = Poping(s, highPrio, result, highScore);
            std::cout << currentStr << std::endl;
            Poping(currentStr, lowPrio, result, lowScore);
            return result;
        }

    private:
        std::string Poping(std::string& target, std::string subString,
                           int& result, int score)
        {
            std::stack<char> st;

            for (char ch : target)
            {
                if (!st.empty() && (std::string() + st.top() + ch) == subString)
                {
                    result += score;
                    st.pop();
                }
                else
                {
                    st.push(ch);
                }
            }

            std::string res;
            while (!st.empty())
            {
                res += st.top();
                st.pop();
            }
            std::reverse(res.begin(), res.end());
            return res;
        }
};