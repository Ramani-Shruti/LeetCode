class Solution {
    public int waysToSplitArray(int[] nums) {
        long  sum = 0;
        for(int n : nums)
        {
            sum+=n;
        }
        int  count = 0;
        long  p = nums[0];
        for(int i=1;i<nums.length;i++)
        {
            long  s = sum - p;
            if(p >= s)
            {
                count++;
            }

            p+=nums[i];
        }
        return count;
    }
}