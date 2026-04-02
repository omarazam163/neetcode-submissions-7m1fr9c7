public class Solution {
    void solve(int i,int sum,List<int> current,List<List<int>> final,int target,int[]nums)
    {
        if(sum>target) return;
        if(sum==target){
            final.Add(new List<int>(current));
            return;
        }
        if(i>=nums.Length) return;

        //take
        current.Add(nums[i]);
        solve(i,sum+nums[i],current,final,target,nums);
        current.RemoveAt(current.Count-1);

        //leave
        solve(i+1,sum,current,final,target,nums);
    }
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<int>current = new();
        List<List<int>> f =new();
        solve(0,0,current,f,target,nums);
        return f;
    }
}
