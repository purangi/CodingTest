using System;
using System.Collections.Generic;

public class Solution {
    bool isValid(string s) {
        Stack<char> st = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++) {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[') {
                st.Push(s[i]);
            } else {
                if(st.Count == 0) return false;
                 if (s[i] == ')' && st.Peek() == '(') st.Pop();
            else if (s[i] == '}' && st.Peek() == '{') st.Pop();
            else if (s[i] == ']' && st.Peek() == '[') st.Pop();
            }
        }
        
        return st.Count == 0 ? true : false;
    }
    public int solution(string s) {
        int answer = 0;
        
        for(int i = 0; i < s.Length; i++) {
            s += s[0];
            s = s.Substring(1);
            
            if(isValid(s)) answer++;
        }
        return answer;
    }
}