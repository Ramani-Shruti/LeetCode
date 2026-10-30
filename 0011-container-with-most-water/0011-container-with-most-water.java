class Solution {
    public int maxArea(int[] height) {
        int l = 0;
        int r = height.length - 1;
        int maxArea = 0;
        while(l < r)
        {
            int w = r-l;
            int h = height[l] < height[r] ? height[l] : height[r];
            int area = h*w;
            if(maxArea <  area)
            {
                maxArea = area;
            }
            if(height[l] < height[r])
            {
                l++;
            }
            else{
                r--;
            }
        }
        return maxArea;
    }
}