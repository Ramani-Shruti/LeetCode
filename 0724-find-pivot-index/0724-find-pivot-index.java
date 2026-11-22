class Solution {
    public int pivotIndex(int[] nums) {
        int[] prifix = new int[nums.length];
        int[] sufix = new int[nums.length];
        for (int i = nums.length - 2; i >= 0; i--) {
            sufix[i] = sufix[i + 1] + nums[i + 1];
        }
        if (sufix[0] == prifix[0]) {
            return 0;
        }
        for (int i = 1; i < nums.length; i++) {
            prifix[i] = prifix[i - 1] + nums[i - 1];
            if (sufix[i] == prifix[i]) {
                return i;
            }
        }
        if (sufix[0] == prifix[0]) {
            return 0;
        }
        return -1;
    }
}