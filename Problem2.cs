using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problem2
{
    public class Solution
    {
        //https://leetcode.com/problems/two-sum/
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int tmp = nums[i];
                String y = "N";
                y.Equals("s");
                bool found = false;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((tmp + nums[j]) == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        found = true;
                        break;
                    }
                }
                if (found) break;

            }
            return result;
        }
    } 
     
    
}
