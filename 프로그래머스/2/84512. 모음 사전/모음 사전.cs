using System;

public class Solution {
    public string[] chars = {"A", "E", "I", "O", "U"};
    int answer = 0;
    int count = 0;
    
    public int solution(string word) {
        
        DFS("", word);
        
        return answer;
    }
    
    public void DFS(string now, string target) {
        if(now.Equals(target)) {
            answer = count;
            return;
        }
        
        if(now.Length == 5) return;
        for(int i = 0; i < chars.Length; i++) {
            count++;
            string word = now + chars[i];
            DFS(word, target);
        }
    }
}