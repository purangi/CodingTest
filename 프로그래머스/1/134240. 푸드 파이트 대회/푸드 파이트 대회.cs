using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        for(int i = 1; i < food.Length; i++) {
            int cnt = food[i] / 2;
            for(int j = 0; j < cnt; j++) {
                answer += i.ToString();
            }
        }
        
        string ans_reverse = new string(answer.Reverse().ToArray());
        answer += "0";
        answer += ans_reverse;
        
        return answer;
    }
}