using System;

public class Solution {
    public int solution(int n) 
    {
        int answer = 0;
        string sNum = n.ToString();
        for(int i = 0; i < sNum.Length; i++)
        {
            answer += (int)Char.GetNumericValue(sNum[i]);
        }   
        return answer;
        
    }
}