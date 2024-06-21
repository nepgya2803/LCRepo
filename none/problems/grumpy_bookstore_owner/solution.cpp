class Solution {
public:
    int maxSatisfied(vector<int>& customers, vector<int>& grumpy, int minutes) {
        int maxMinutes {};
        int total {};
        for(int i = 0; i < customers.size(); i++){
            if(grumpy[i] == 0) total += customers[i];
        }

        for(int i = 0; i < minutes; i++){
            if(grumpy[i] == 1) maxMinutes+= customers[i];
        }
        int window_sum = maxMinutes;
        for(int i = minutes; i < customers.size(); i++){
            if(grumpy[i] == 1){
                window_sum += customers[i];
            }
            if(grumpy[i - minutes] == 1){
                window_sum -= customers[i-minutes];
            }
            maxMinutes = max(maxMinutes, window_sum);
        }

        return total + maxMinutes;
    }
};