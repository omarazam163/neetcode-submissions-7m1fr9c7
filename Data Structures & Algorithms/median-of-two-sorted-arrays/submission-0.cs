public class Solution {
            public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] A = nums1;
            int[] B = nums2;
            int total = A.Length + B.Length;
            int half = (total+1) / 2;
            if(A.Length>B.Length)
            {
                A = nums2;
                B= nums1;
            }
            int l = 0;
            int r = A.Length;
            while (l <= r) 
            {
                int i = (r + l) / 2; //pointer to left 
                int j = half -i;
                int ALeft = (i>0)?A[i-1]: int.MinValue;
                int Bleft = (j>0)?B[j-1]: int.MinValue;
                int ARight = (i < A.Length) ? A[i]:int.MaxValue;
                int BRight = (j < B.Length) ? B[j] : int.MaxValue;
                if(ALeft<= BRight && Bleft <= ARight)
                {
                    if(total%2==0)
                    {
                        return ((double)(int.Max(ALeft, Bleft) + int.Min(ARight, BRight)) / 2);
                    }
                    else
                    {
                        return int.Max(ALeft, Bleft);
                    }
                }
                else if(ALeft>BRight)
                {
                    r = i - 1;
                }
                else
                {
                    l = i + 1;
                }
            }
            return -1;
        }
}