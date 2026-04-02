public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       var hashMap = new Dictionary<int,int>();
       var res = new int[2];
       for(int i = 0; i < nums.Length; i++)
       {
          if (hashMap.TryGetValue(target - nums[i], out int index))
          {
            res[0] = index;
            res[1] = i;
            return res;
          }
          else
          {
            hashMap[nums[i]] = i;
          }
       }
       return res;
    }
}
