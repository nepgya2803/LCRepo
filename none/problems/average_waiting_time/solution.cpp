class Solution {
public:
    double averageWaitingTime(vector<vector<int>>& customers) {
        double total = 0;
        int finish = 0;

        for(vector<int> i : customers)
        {
            finish = std::max((int)finish, i[0]) + i[1];
            total += finish - i[0];
        }

        return total / customers.size();
    }
};