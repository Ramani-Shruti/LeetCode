public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int start = 0;
        int maxLength = 0;

        Dictionary<char, int> lastIndex = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (lastIndex.ContainsKey(s[i]))
            {
                start = Math.Max(start, lastIndex[s[i]] + 1);
            }

            lastIndex[s[i]] = i;

            int currentLength = i - start + 1;

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}