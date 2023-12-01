using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] number = n.ToString().ToCharArray();
        
        Array.Sort(number);
        Array.Reverse(number);
        answer = long.Parse(new string(number));
        return answer;
    }
}