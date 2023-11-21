using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        float num = 0;
        float num3 = 0;
        
        num3 = (float)num1 / (float)num2;
        num = num3 * 1000;
        answer = (int)num;
        
        return answer;
    }
}