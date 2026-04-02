    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            List<int> sequenceStarters = new List<int>();
            HashSet<int> numSet = new HashSet<int>(nums);

            for (int i=0;i<nums.Length;i++)
            {
                if(!numSet.Contains(nums[i]-1))
                {
                    sequenceStarters.Add(nums[i]);
                }   
            }
            int maxLenghtSeq = 0;
            for (int i=0;i<sequenceStarters.Count;i++)
            {
                int count = 0;
                while (numSet.Contains(sequenceStarters[i]+count))
                {
                    count++;
                    if(maxLenghtSeq<count) maxLenghtSeq = count;
                }
            }
            return maxLenghtSeq;
        }
    }