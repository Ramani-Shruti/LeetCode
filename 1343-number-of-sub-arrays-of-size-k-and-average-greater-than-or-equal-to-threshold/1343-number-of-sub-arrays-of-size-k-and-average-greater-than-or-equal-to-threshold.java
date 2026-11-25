class Solution {
    public int numOfSubarrays(int[] arr, int k, int th) {
        int ws = 0;
        int n = arr.length;
        int count = 0;
        for (int i = 0; i < k; i++) {
            ws += arr[i];

        }
        if (ws / k >= th) {
            count++;
        }
        for (int i = k; i < n; i++) {
            ws += arr[i] - arr[i - k];
            if (ws / k >= th) {
                count++;
            }
        }
        return count;
    }
}