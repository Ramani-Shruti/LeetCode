public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        char[] arr = new char[s.Length];

        int start = 0;
        int count = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            bool found = false;

            for (int j = start; j < i; j++)
            {
                if (arr[j] == s[i])
                {
                    found = true;
                    start = j + 1;
                    break;
                }
            }

            arr[i] = s[i];

            int length = i - start + 1;

            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        return maxLength;
    }
}