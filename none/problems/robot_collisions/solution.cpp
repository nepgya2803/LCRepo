class Solution
{
    public:
        std::vector<int> survivedRobotsHealths(std::vector<int>& positions,
                                               std::vector<int>& healths,
                                               std::string directions)
        {
            int n = positions.size();
            std::vector<int> result;
            std::vector<int> tracker(n);

            std::stack<int> stk;

            for (int i = 0; i < n; i++)
            {
                tracker[i] = i;
            }

            std::sort(tracker.begin(), tracker.end(),
                      [&](int lhs, int rhs)
                      { return positions[lhs] < positions[rhs]; });

            for (int currentIndex : tracker)
            {
                if (directions[currentIndex] == 'R')
                {
                    stk.push(currentIndex);
                }
                else
                {
                    while (!stk.empty() && healths[currentIndex] > 0)
                    {
                        int top = stk.top();
                        stk.pop();

                        if (healths[top] > healths[currentIndex])
                        {
                            healths[top] -= 1;
                            healths[currentIndex] = 0;
                            stk.push(top);
                        }
                        else if (healths[top] < healths[currentIndex])
                        {
                            healths[currentIndex] -= 1;
                            healths[top] = 0;
                        }
                        else
                        {
                            healths[top] = 0;
                            healths[currentIndex] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (healths[i] > 0)
                {
                    result.push_back(healths[i]);
                }
            }

            return result;
        }
};