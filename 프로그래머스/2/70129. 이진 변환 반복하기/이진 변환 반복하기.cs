using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        
        int zeroCnt = 0;
        int cnt = 0;
        
        while(s != "1") {
            string newStr = s.Replace("0", string.Empty);
            
            zeroCnt += (s.Length - newStr.Length);
            cnt++;
            s = Convert.ToString(newStr.Length, 2);
        }
        
        answer[0] = cnt;
        answer[1] = zeroCnt;
        return answer;
    }
}