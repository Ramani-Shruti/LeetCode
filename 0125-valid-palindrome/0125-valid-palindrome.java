class Solution {
    public boolean isPalindrome(String s) {
        String work = s.replaceAll("[^a-zA-Z0-9]","").toLowerCase();
        int left = 0;
        int right = work.length() - 1;
        boolean flag = true;
        while(left<=right)
        {
            if(work.charAt(left) != work.charAt(right))
            {
                flag = false;
                break;
            }
            left++;
            right--;
        }
        return flag;
    }
}