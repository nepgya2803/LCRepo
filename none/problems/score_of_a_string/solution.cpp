class Solution {
public:
        int scoreOfString(std::string s) {
            int sum = 0;
            for(int i = 0; i < s.length() -1; i++)
            {
                sum += abs(s[i] - s[i+1]);
            }
            return sum;
        }
};