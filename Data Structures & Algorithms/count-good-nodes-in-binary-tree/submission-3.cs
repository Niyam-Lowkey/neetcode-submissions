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
        //int rootval = root.val;

        Queue<(TreeNode node,int maxValue)> queue = new();
        queue.Enqueue((root,root.val));
        int goodNodes = 0;
        while(queue.Count > 0){
            var (node,maxValue) = queue.Dequeue();

            if(node.val >= maxValue){
                goodNodes++;
                maxValue = node.val;
            }            
           
            if(node.left != null)
                queue.Enqueue((node.left, maxValue));

            if(node.right != null)
                queue.Enqueue((node.right, maxValue));    

        }

        return goodNodes;
        
    }
}
