public class Solution
{
    public int Reverse(int x)
    {
        long result = 0;

        while (x != 0)
        {
            result = result * 10 + x % 10;
            x /= 10;
        }

        return result < int.MinValue || result > int.MaxValue
            ? 0
            : (int)result;
    }
}