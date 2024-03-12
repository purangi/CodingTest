using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        
        s = s.ToLower();
        char[] temp = s.ToCharArray();
        
        for(int i=0; i<temp.Length; i++)
        {
            temp[0] = Char.ToUpper(temp[0]);
            if(temp[i] == ' ' && i+1<temp.Length)
            {
                temp[i+1] = Char.ToUpper(temp[i+1]);
            }
        }
        
        for(int i = 0; i < temp.Length; i++) {
            answer += temp[i].ToString();
        }
        
        
        return answer;
    }
}