
public class Solution 
{
        public bool hasDuplicate(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (keyValuePairs.Keys.Contains(num))
                {
                    return true;
                }
                else
                {
                    keyValuePairs.Add(num, 1);
                }
            }
            return false;
        }
}
