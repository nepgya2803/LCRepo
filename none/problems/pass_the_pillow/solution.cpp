class Solution {
public:
    int passThePillow(int n, int time) {
        return time / (n - 1) % 2 != 0 ? n - (time % (n - 1))
                                       : 1 + (time % (n - 1));
    }
};