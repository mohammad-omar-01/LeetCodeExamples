using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{//https://leetcode.com/problems/construct-string-from-binary-tree/

    // Definition for a binary tree node.
    public class TreeNode {
       public int val;
       public TreeNode left;
       public TreeNode right;
       public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
           this.val = val;
           this.left = left;
            
           this.right = right;
       }
   }
  
    public class Solution
    {
        String result = "";
        public string Tree2str(TreeNode root)
        {
            if (root == null)
            {
                return "";
                
            }
            result += root.val.ToString();
            if (root.left == null && root.right == null) return result;
            result += "(";
            
            Tree2str(root.left);
            result += ")";


            if (root.right != null)
            {
                result += "(";
                Tree2str(root.right);
                result += ")";
            }


            return result;
        }
    }
}
