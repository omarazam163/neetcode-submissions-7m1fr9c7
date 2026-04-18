public class Solution {
    public int Search(int[] nums, int target) {
        var r = nums.Length - 1;
        var l = 0;
        
        while (r >= l)
        {
            var m = (l + r) / 2;
            if (nums[m] == target)
                return m;
            if (nums[m] >= nums[l]) // left portion
            {
                if (target > nums[m]) // target is bigger than the m
                {
                    l = m + 1;
                }
                else // target is bigger than m 
                {
                    if (target < nums[l])
                        l = m + 1;
                    else if(target == nums[l])
                        return l;
                    else
                        r = m - 1;
                }
            }
            else
            {
                if (target > nums[m])
                {
                    if (target < nums[r])
                    {
                        l = m + 1;
                    }
                    else if (target == nums[r])
                        return r;
                    else
                        r = m - 1;
                }
                else
                {
                    r = m - 1;
                }
            }
        }

        return -1;
    }
}