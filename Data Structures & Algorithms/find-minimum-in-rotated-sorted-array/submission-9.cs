public class Solution {
    public int FindMin(int[] nums) {
        var l = 0;
        var r = nums.Length - 1;

        var min = int.MaxValue;

        while (r >= l)
        {
            if (nums[r] > nums[l])
            {
                min = Math.Min(min, nums[l]);
                break;
            }
            var m = (l + r) / 2;
            min = Math.Min(nums[m], min);
            if (nums[m] >= nums[l])
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }

        }

        return min; 
    }
}
