using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        
        long intP = long.Parse(p);
        for(int i = 0; i <= t.Length - p.Length; i++) {
            long intT = long.Parse(t.Substring(i, p.Length));
            if(intT <= intP) answer++;
        }
        return answer;
    }
}