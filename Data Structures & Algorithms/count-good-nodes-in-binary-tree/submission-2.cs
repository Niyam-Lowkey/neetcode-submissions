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
    public int GoodNodes(TreeNode root) {
        return DFS(root, int.MinValue);
    }

    private int DFS(TreeNode node, int maxValue){

        if(node == null)
            return 0;

        if(node.val >= maxValue){
            maxValue = node.val;
            return 1 + DFS(node.left, maxValue) + DFS(node.right, maxValue);
        }

        
        return DFS(node.left, maxValue) + DFS(node.right, maxValue);    

    }
}
