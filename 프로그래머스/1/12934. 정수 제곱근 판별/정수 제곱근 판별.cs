using System;

public class Solution {
    public long solution(long n) 
    {
        long answer = 0;
        double x = Math.Sqrt(n);
        
        if(x % 1 == 0)
        {
            answer = ((long)x+1)*((long)x + 1);   
        }
        else
            answer = -1;
        
        return answer;
    }
}