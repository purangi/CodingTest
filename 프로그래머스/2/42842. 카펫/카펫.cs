using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        
        int x, y;
        int width = brown + yellow;
        
        for(int i = 1; i <= width; i++) {
            x = i;
            y = width / x;
            
            if(x > y || x == y) {
                if(width - (2 * x + 2 * y - 4) == yellow) {
                    answer[0] = x;
                    answer[1] = y;
                    break;
                }
            }
        }
        
        return answer;
    }
}