using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        Dictionary<char, int> dic = new Dictionary<char, int>();
        
        for(int i = 0; i < s.Length; i++) {
            if(dic.ContainsKey(s[i])) {
                int temp = i - dic[s[i]];
                answer[i] = temp;
                dic[s[i]] = i;
            } else {
                answer[i] = -1;
                dic.Add(s[i], i);
            }
        }
        return answer;
    }
}