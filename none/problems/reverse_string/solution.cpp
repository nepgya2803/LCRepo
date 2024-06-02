class Solution {
public:
    void reverseString(vector<char>& s) {
        int length  = s.size() - 1;
            int midInd = length / 2;
            for(int i = 0; i <= midInd; i ++)
            {
                char tmp = s[i];
                s[i] = s[length - i];
                s[length - i] = tmp;
            }
    }
};