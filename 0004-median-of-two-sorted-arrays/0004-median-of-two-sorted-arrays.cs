public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] result = new int[nums1.Length + nums2.Length];

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] <= nums2[j])
            {
                result[k] = nums1[i];
                i++;
            }
            else
            {
                result[k] = nums2[j];
                j++;
            }

            k++;
        }

        // Remaining elements of nums1
        while (i < nums1.Length)
        {
            result[k] = nums1[i];
            i++;
            k++;
        }

        // Remaining elements of nums2
        while (j < nums2.Length)
        {
            result[k] = nums2[j];
            j++;
            k++;
        }

        int mid = result.Length / 2;

        if (result.Length % 2 == 0)
        {
            return ((double)result[mid - 1] + result[mid]) / 2;
        }

        return result[mid];
    }
}