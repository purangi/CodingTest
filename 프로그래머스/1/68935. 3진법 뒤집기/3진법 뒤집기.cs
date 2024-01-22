using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        string s = "";
        while(n > 0) {
            s += (n % 3).ToString();
            n /= 3;
        }
        
        int length = s.Length - 1;
        
        for(int i = 0; i < s.Length; i++) {
            answer += int.Parse(s[i].ToString()) * (int) Math.Pow(3, length - i);
        } 
        return answer;
    }
}