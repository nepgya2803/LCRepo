class Solution
{
    public:
    long long maximumImportance(int n, std::vector<std::vector<int>>& roads) {
        long long max = 0; max = 0;
        std::vector<int> storage = std::vector<int> (n, 0);
    
        for(int i = 0; i < roads.size(); i++)
        {
            int u = roads[i][0];
            int v = roads[i][1];
            storage[u]++;
            storage[v]++;
        }
        
        int ind = 1;
        int i = 0;

        std::sort(storage.begin(), storage.end());

        while(n > 0)
        {
            max += storage[n - 1] * (long long)n;
            n--;
        }

        return max;
    }
};