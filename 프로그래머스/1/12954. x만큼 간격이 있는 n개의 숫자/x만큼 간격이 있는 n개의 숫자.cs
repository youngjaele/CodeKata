public class Solution {
    public long[] solution(int x, int n) 
    {
        long[] answer = new long[n];
        long longX = x;
        
        for (int i = 0; i < n; i++)
        {
            answer[i] = longX;
            longX += x;
        }
        return answer;
    }
}