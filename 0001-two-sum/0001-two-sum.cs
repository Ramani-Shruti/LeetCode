public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> d1 = new Dictionary<int,int>();
        for(int i=0;i < nums.Length;i++)
        {
            int c = target - nums[i];
            if(d1.ContainsKey(c))
            {
                return new int[]{d1[c],i};
            }
            d1[nums[i]]=i;
        }
        return Array.Empty<int>();
    }
}