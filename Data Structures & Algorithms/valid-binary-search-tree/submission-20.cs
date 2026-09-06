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
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
            return true;

        Queue<(TreeNode node, long min, long max)> queue = new();

        queue.Enqueue((root, long.MinValue, long.MaxValue));

        while (queue.Count > 0)
        {
            var (node, min, max) = queue.Dequeue();

            if (node.val <= min || node.val >= max)
                return false;

            if (node.left != null)
            {
                queue.Enqueue((node.left, min, node.val));
            }
            
            if (node.right != null)
            {
                queue.Enqueue((node.right, node.val, max));
            }
        }

        return true;
    }
}
