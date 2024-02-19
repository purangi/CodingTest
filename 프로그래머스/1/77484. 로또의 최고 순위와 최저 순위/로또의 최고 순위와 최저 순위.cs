using System;

public class Solution {
    bool isContained(int n, int[] win_nums) {
        for(int i = 0; i < win_nums.Length; i++) {
            if(n == win_nums[i]) return true;
        }
        
        return false;
    }
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        
        int win = 0; int lose = 0;
        
        for(int i = 0; i < lottos.Length; i++) {
            if(lottos[i] == 0) continue;
            
            if(isContained(lottos[i], win_nums)) win++;
            else lose++;
        }
        
        answer[0] = lose > 5 ? lose : lose + 1;
        answer[1] = win > 0 ? 7 - win : 6 - win;
        
        return answer;
    }
}