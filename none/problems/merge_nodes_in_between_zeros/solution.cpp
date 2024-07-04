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
class Solution {
public:
    ListNode* mergeNodes(ListNode* head) {
        ListNode* ptr = head->next;
        ListNode* dummy = new ListNode();
        ListNode* ans = dummy;

        while (ptr != nullptr) {
            dummy->val += ptr->val;

            if (ptr->val == 0 && ptr->next != nullptr) {
                dummy->next = new ListNode();
                dummy = dummy->next;
            }

            ptr = ptr->next;
        }

        return ans;
    }
};