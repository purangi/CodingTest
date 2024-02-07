using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        
        int a = 0;
        int b = 0;
        for(int i = 0; i < goal.Length; i++) {
            if(a < cards1.Length) {
                if(goal[i] == cards1[a]) {
                    a++;
                    continue;
                }
            }
            
            if(b < cards2.Length) {
                if(goal[i] == cards2[b]) {
                    b++;
                    continue;
                }
            }
            
            answer = "No";
            break;
            
        }
        return answer;
    }
}