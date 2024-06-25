/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode BstToGst(TreeNode root) {
        int sum = 0;
        TransformTree(root, ref sum);
        return root;
    }
    private void TransformTree(TreeNode node, ref int sum) {
        if (node == null) {
            return;
        }

        // Traverse the right subtree first
        TransformTree(node.right, ref sum);

        // Update the current node's value with the cumulative sum
        sum += node.val;
        node.val = sum;

        // Traverse the left subtree
        TransformTree(node.left, ref sum);
    }
}