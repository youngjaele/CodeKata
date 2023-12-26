public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int[] answer = new int[2];
        int min = n;
        int max = m;
        int num = 0;
        
        while(m > 0)
        {
            int temp = n;
            n = m;
            m = temp % m;
            num = n;
        }
        answer[0] = num;
        answer[1] = min * max / num;
        return answer;
    }
}