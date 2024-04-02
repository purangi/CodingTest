using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answer = new List<int>();
        
        int cnt = 0;
        while(true) {
            int temp = 0;
            
            for(int i = 0; i < progresses.Length; i++) {
                progresses[i] += speeds[i];
            }
            
            for(int i = cnt; i < progresses.Length; i++) {
                if(progresses[i] >= 100) temp++;
                else {
                    cnt = i;
                    break;
                }
            }
            
            if(temp > 0) answer.Add(temp);
            if(progresses[cnt] >= 100) break;
        }
        return answer.ToArray();
    }
}