class Solution
{
public:
    int minDifference(std::vector<int> &nums)
    {
        if (nums.size() <= 4)
            return 0;

        sort(nums.begin(), nums.end());
        long left = 0;
        long right = nums.size() - 4;
        int small = nums[right] - nums[left];

        for (; left < 4; left++, right++)
        {
            small = std::min(small, (nums[right] - nums[left]));
        }

        return small;
    }
};