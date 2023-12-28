public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        
        int num = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            answer += num % 2 == 0 ? char.ToUpper(s[i]) : char.ToLower(s[i]);
            num = s[i] == ' ' ? 0 : num += 1;
        }
        return answer;
    }
}