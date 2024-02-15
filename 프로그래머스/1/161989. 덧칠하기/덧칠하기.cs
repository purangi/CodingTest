using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        
        List<int> repainted = new List<int>();
        
        for(int i = 0; i < section.Length; i++) {
            
            if(!repainted.Contains(section[i])) {
                for(int j = 0; j < m; j++) {
                    repainted.Add(section[i] + j);
                }
                answer++;
            }
        }
        return answer;
    }
}