class Solution {
public:
    bool isPalindrome(int x) {
        if(x < 0) return false;

        long long newNum = 0;
        long long tmp = x;
        
        while(tmp != 0)
        {
            long long remainder = tmp % 10;
            newNum = newNum * 10 + remainder;
            tmp /= 10;
        }

        return (int)newNum == x;
    }
};