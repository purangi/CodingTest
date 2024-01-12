using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        string s = n.ToString();
        for(int i = s.Length - 1; i >= 0; i--) {
            int a = n / (int) Math.Pow(10, i);
            n -= a * (int) Math.Pow(10, i);
            answer += a;
        }
        return answer;
    }
}