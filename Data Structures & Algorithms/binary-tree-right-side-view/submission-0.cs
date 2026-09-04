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
    public List<int> RightSideView(TreeNode root) {
        
        List<int> res = new List<int>();

        DFS(root, 0, res);

        return res;

    }

    public void DFS(TreeNode root, int depth, List<int> res){

        if(root == null)
            return;

        if(depth == res.Count)
            res.Add(root.val);

        DFS(root.right, depth + 1, res);

        DFS(root.left, depth + 1, res);

    }

    }
