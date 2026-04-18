public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while (r >= l)
        {
            var m =  (l + r) / 2;
            if (nums[m] == target)
                return m;
            if (nums[m] > target)
            {
                r = m - 1;
            }    
            else
            {
                l = m + 1;
            }
        }

        return -1;
    }
}
