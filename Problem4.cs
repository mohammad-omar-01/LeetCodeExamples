using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
//https://leetcode.com/problems/longest-common-prefix/
{
    class Longestprefix
    {
        public String LongestCommonPrefix(string[] strs)
        {


            int max = 0;
            String? mostOccured = "";
            char[] tmp = strs[0].ToCharArray();
            int min = 201;
            foreach (var y in strs)
            {
                if (y.Length < min)
                {
                    min = y.Length;
                }
            }
            List<char> result = new List<char>();


            for (var j = 0; j < min; j++)
            {
                bool flag = false;
                for (var i = 0; i < strs.Length; i++)
                {
                    var y = (strs[i].ToCharArray()[j]);
                    if (y != tmp[j])
                    {
                        flag = true;
                        break;
                    }

                }
                if (!flag)
                {
                    result.Add(tmp[j]);
                }
                else { break; }
            }


            return String.Concat(result);

        }
    }
}
