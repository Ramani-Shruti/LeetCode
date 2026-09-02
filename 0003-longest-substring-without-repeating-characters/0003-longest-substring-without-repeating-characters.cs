public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int[] lastIndex = new int[128];

        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (lastIndex[s[i]] > start)
            {
                start = lastIndex[s[i]];
            }

            lastIndex[s[i]] = i + 1;

            int length = i - start + 1;

            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        return maxLength;
    }
}