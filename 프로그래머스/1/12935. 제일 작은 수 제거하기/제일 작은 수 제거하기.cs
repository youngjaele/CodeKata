using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) 
    {
        List<int> answer = new List<int>();
        {
            foreach (int num in arr)
                answer.Add(num);
            int min = answer.Min();
            answer.Remove(min);
            if(answer.Count ==0)
            {
                answer.Add(-1);
            }
        }
        return answer.ToArray();
    }
}