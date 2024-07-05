/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution
{
public:
    std::vector<int> nodesBetweenCriticalPoints(ListNode *head)
    {
        int currIndex = 1;
        int prevCritIndex = 0;
        int firstCritIndex = 0;

        int max = 0;
        int min = INT_MAX;

        ListNode *prev = head;
        ListNode *curr = head->next;

        while (curr->next != nullptr)
        {
            if ((curr->val > prev->val && curr->val > curr->next->val) || (curr->val < prev->val && curr->val < curr->next->val))
            {
                if (prevCritIndex == 0)
                {
                    firstCritIndex = currIndex;
                    prevCritIndex = currIndex;
                }
                else
                {
                    max = std::max(currIndex - firstCritIndex, max);
                    min = std::min(min, currIndex - prevCritIndex);
                    prevCritIndex = currIndex;
                }
            }

            prev = curr;
            curr = curr->next;
            currIndex++;
        }

        if (min == INT_MAX)
        {
            return {-1, -1};
        }

        return {min, max};
    }
};