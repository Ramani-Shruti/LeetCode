public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> strD = new Dictionary<char, int>();

        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (strD.ContainsKey(s[i]) && strD[s[i]] >= start)
            {
                start = strD[s[i]] + 1;
            }

            strD[s[i]] = i;

            int currentLength = i - start + 1;

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}