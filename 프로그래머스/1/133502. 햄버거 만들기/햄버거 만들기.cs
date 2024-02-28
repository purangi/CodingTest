using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> list = new List<int>();
        
        foreach(int burger in ingredient) {
            list.Add(burger);
            
            int cnt = list.Count;
            if(cnt >= 4) {
                if(list[cnt - 4] == 1 && list[cnt - 3] == 2 && list[cnt - 2] == 3 && list[cnt - 1] == 1) {
                    answer++;
                    list.RemoveRange(cnt - 4, 4);
                }
            }
        }
        return answer;
    }
}