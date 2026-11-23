class Solution {
    public int waysToSplitArray(int[] nums) {
        long  sum = 0;
        for(int n : nums)
        {
            sum+=n;
        }
        int  count = 0;
        long  p = 0;
        for(int i=0;i<nums.length-1;i++)
        {
            p+=nums[i];
            if(p >= sum - p)
                count++;
        }
        return count;
    }
}