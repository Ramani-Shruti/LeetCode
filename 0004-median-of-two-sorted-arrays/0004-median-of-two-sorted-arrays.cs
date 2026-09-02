public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length+nums2.Length];
        Array.Copy(nums1,0,result,0,nums1.Length);
        Array.Copy(nums2,0,result,nums1.Length,nums2.Length);
        Array.Sort(result);
        int min;
        double r;
        min = result.Length/2;
        if(result.Length%2 == 0)
        {
            r = result[min -1] + result[min];
            r = r/2;
        }
        else
        {
            if(min==result.Length)
            {
                r = result[0];
            }
            else
            {
                r = result[min];
            }
          
        }
        return r;
    }
}