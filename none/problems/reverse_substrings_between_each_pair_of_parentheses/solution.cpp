class Solution
{
    public:
        std::string reverseParentheses(std::string s)
        {
            std::stack<int> st;
            std::string result;

            for (char ch : s)
            {
                if (ch == '(')
                {
                    st.push(result.length());
                }
                else if (ch == ')')
                {
                    int start = st.top();
                    st.pop();
                    std::reverse(result.begin() + start, result.end());
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }
};