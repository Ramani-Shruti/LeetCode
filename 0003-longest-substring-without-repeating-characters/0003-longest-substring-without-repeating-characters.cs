public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int start = 0;
        int maxLength = 0;

        bool[] seen = new bool[128];

        for (int i = 0; i < s.Length; i++)
        {
            // Character already exists
            while (seen[s[i]])
            {
                seen[s[start]] = false;
                start++;
            }

            // Add current character
            seen[s[i]] = true;

            // Calculate current substring length
            int currentLength = i - start + 1;

            // Update maximum
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}