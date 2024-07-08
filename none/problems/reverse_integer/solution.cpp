class Solution {
public:
    int reverse(int x) {
        long long output = 0;

        while(x != 0)
        {
            output = output * 10 + x % 10;
            x /= 10;
        }

        if(x < 0) output *= -1;

        if(abs(output) >= INT32_MAX)
        {
            return 0;
        }

        return output;
    }
};