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

    int preOrderIndex = 0;
    Dictionary<int,int> inorderList = new();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {

        
        for(int i = 0; i < inorder.Length; i++){

            inorderList[inorder[i]] = i;                

        }

        return build(preorder, 0, inorder.Length - 1);
             
    }

    private TreeNode build(int[] preorder, int left, int right){

        if(left > right)
            return null;

        int rootValue = preorder[preOrderIndex];
        preOrderIndex ++;    

        TreeNode root = new TreeNode(rootValue);

        int rootIndex = inorderList[rootValue];

        root.left = build(preorder, left, rootIndex - 1);

        root.right = build(preorder, rootIndex + 1, right);

        return root;            
    }
}
