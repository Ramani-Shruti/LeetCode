class Solution {
    public int trap(int[] nums) {
        int lm = 0;
        int rm = 0;
        int l = 0;
        int r = nums.length - 1 ;
        int sum  = 0;
        while(l<r)
        {
            lm = Math.max(lm,nums[l]);
            rm = Math.max(rm,nums[r]);
            if(lm<rm)
            {
                sum += (lm-nums[l]);
                l++;
            }
            else{
                sum += (rm-nums[r]);
                r--;
            }
        }
        return sum;
    }
}