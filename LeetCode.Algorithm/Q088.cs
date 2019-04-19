using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    public class Q088
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int length = m + n;
            for (int i = length; i > 0; i--)
            {
                if (m == 0 || n == 0)
                    nums1[i - 1] = m == 0 ? nums2[--n] : nums1[--m];
                else if (nums1[m - 1] > nums2[n - 1])
                    nums1[i - 1] = nums1[--m];
                else
                    nums1[i - 1] = nums2[--n];
            }
        }

        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            int length = m + n;
            for (int i = length; i > 0; i--)
            {
                if (m <= 0)
                {
                    nums1[i - 1] = nums2[--n];
                }
                else if (n <= 0)
                {
                    nums1[i - 1] = nums1[--m];
                }
                else if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[i - 1] = nums1[--m];
                }
                else
                    nums1[i - 1] = nums2[--n];
            }
        }
    }
}
