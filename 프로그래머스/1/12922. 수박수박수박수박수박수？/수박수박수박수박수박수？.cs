public class Solution 
{
    public string solution(int n)
    {
        string answer = "";
        int Length = n/2;
        
        for (int i = 0; i<Length; i++)
        {
            answer += "수박";
        }
        if ( n%2 == 1)
        {
            answer += "수";
        }
        
        return answer;
    }
}