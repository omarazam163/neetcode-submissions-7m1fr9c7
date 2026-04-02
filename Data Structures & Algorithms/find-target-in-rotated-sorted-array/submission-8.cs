public class Solution
{
        public int Search(int[] nums, int target)
        {
            // int l = 0;
            // int r = nums.Length - 1;
            // while (r >= l)
            // {
            //     int m = (r + l) / 2;
            //     if (nums[0]>target)
            //     {
            //         if (nums[m] < nums[0])
            //         {
            //             if (nums[m] == target) return m;
            //             if (nums[m]>target)
            //             {
            //                 r=m-1;
            //             }
            //             else
            //             {
            //                 l = m + 1;
            //             }
            //         }
            //         else
            //         {
            //             l = m + 1;
            //         }
            //     }
            //     else
            //     {
            //         if (nums[m] >= nums[0])
            //         {
            //             if (nums[m] == target) return m;
            //             if (nums[m] > target)
            //             {
            //                 r = m - 1;
            //             }
            //             else
            //             {
            //                 l = m + 1;
            //             }
            //         }
            //         else
            //         {
            //             r = m - 1;
            //         }
            //     }
            // }
            // return -1;

                int l = 0;
                int r = nums.Length - 1;
                while (r >= l)
                {
                    Console.WriteLine($"{l} {r}");
                    int m = (l + r) / 2;
                    if (nums[m] == target)
                    {
                        return m;
                    }
                    if (nums[l] > target)
                    {
                        l++;
                    }
                    else if (nums[r] < target)
                    {
                        r--;
                    }
                    else
                    {
                        if (nums[m] > target) r = m - 1;
                        else l = m + 1;
                    }
                }
                return -1;
        }
}
