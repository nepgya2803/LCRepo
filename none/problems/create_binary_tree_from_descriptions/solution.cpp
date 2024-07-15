/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    TreeNode* createBinaryTree(vector<vector<int>>& descriptions) {
        unordered_map<int, TreeNode*> mp;
        for(auto i : descriptions) {
            if(mp.find(i[0]) == mp.end()) {
                TreeNode *tmp = new TreeNode(i[0]);
                mp[i[0]] = tmp;
            }
            if(mp.find(i[1]) == mp.end()) {
                TreeNode *tmp = new TreeNode(i[1]);
                mp[i[1]] = tmp;
            }
        }
        set<int> st;
        for(auto i : descriptions) {
            st.insert(i[1]);
        }
        int newroot;
        for(auto i : descriptions) {
            if(st.find(i[0]) == st.end()) {
                newroot = i[0];
                break;
            }
        }
        for(auto i : descriptions) {
            if(i[2] == 1) {
                mp[i[0]]->left = mp[i[1]];
            }
            else {
                mp[i[0]]->right = mp[i[1]];
            }

        }
        for(auto i : mp) {
            if(i.first == newroot) {
                return i.second;
            }
        }
        return nullptr;
    }
};