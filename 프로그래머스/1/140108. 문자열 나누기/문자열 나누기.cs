using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        int first = 0;
        int other = 0;
        
        char temp = s[0];
        
        int i;
        for(i = 0; i < s.Length - 1; i++) {
            if(temp == s[i]) first++;
            else other++;
            
            if(first == other) {
                first = 0;
                other = 0;
                answer++;
                
                temp = s[i+1];
            }
            
        }
        
        if((s = s.Substring(i)).Length != 0) answer++;
        
        return answer;
    }
}