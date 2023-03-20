using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    class MedianofArray
    {

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int size = nums1.Length + nums2.Length;
            int[] unsorted = new int[size];

            unsorted = nums1.Concat(nums2).ToArray();



            Array.Sort<int>(unsorted);
            if (size % 2 == 1)
            {
                return (double)(unsorted[size / 2]);
            }
            var middle_element = size / 2;
            double median = (unsorted[middle_element] + unsorted[middle_element - 1]) / 2.0;
            return median;

        }

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

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }


    }
}
