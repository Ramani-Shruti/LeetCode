public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length+nums2.Length];
        Array.Copy(nums1,0,result,0,nums1.Length);
        Array.Copy(nums2,0,result,nums1.Length,nums2.Length);
        Array.Sort(result);
        int min;
        double r;
        if(result.Length%2 == 0)
        {
            min = (result.Length/2) - 1 ;
            r = result[min] + result[min + 1];
            r = r/2;
        }
        else
        {
            min = (result.Length/2);
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