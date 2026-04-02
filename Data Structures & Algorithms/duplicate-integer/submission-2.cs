    public class Solution
    {
        public bool hasDuplicate(int[] nums)
        {
            var hashset = new HashSet<int>();
            foreach(var num in nums)
            {
                if(!hashset.Add(num))
                {
                    return true;
                }
            }
            return false;
        }
    }