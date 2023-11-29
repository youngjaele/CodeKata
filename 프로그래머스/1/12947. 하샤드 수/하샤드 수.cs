using System;

public class Solution {
    public bool solution(int x) 
    {
        string s = x.ToString();
        int sum = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            sum += (int)Char.GetNumericValue(s[i]);
        }
        bool answer = x % sum == 0 ? true : false;
        return answer;
    }
}