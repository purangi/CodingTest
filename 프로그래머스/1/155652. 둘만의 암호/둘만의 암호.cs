using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        char c;
        
        for(int i = 0; i < s.Length; i++) {
            c = s[i];
            
            for(int j = 0; j < index;){
                c = (char)((int)c + 1);
                if(c > 'z') c = 'a';
                if(skip.Contains(c) == true) continue;
                j++;
            }
                
            answer += c;
        }
        return answer;
    }
}