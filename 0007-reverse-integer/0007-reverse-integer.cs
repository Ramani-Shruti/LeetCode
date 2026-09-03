public class Solution {
    public int Reverse(int x) 
    {
        int n;
        long  result = 0;
        while(x != 0)
        {
            n = x%10;
            x = x/10;
            result = (n + result) * 10;
            if(result <= int.MinValue * 10L || result >= int.MaxValue * 10L)
            {
                return 0;
            }
        }
        return (int)(result/10);
    }
}