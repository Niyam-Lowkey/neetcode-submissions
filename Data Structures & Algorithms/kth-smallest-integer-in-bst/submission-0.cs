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
    public int KthSmallest(TreeNode root, int k) {        
        return InOrder(root, k);        
    }

    private int count = 0;

    private int InOrder(TreeNode node, int smallestindex){

        if(node == null)
            return -1;

        int left = InOrder(node.left, smallestindex);

        if (left != -1)
            return left;

        count++;

        if(smallestindex == count)
            return node.val;

        return InOrder(node.right, smallestindex);        
    }
}
