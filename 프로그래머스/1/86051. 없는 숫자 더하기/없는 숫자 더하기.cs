using System;

public class Solution
{
    public int solution(int[] numbers) 
    {
        int answer = 0;
        
        int temp = 0;
        for (int i = 0; i <= 9; i++)
        {
            temp += i;
        }
        
        int temp1 = 0;
        for (int j = 0; j < numbers.Length; j++)
        {
            temp1 += numbers[j];
        }
        
        answer = temp - temp1;
        return answer;
    }
}