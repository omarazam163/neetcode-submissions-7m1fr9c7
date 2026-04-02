public class Solution {
                public int LongestConsecutive(int[] nums)
            {
                HashSet<int> hashed=nums.ToHashSet();
                int len = 0;
                foreach (int i in hashed) { 
                int j = 0;
                if(!hashed.Contains(i-1))
                    {
                        while(hashed.Contains(i+j))
                        {
                            j++;
                        } 
                    }
                if(j>len) len = j;
                }
                return len;
            }
}
