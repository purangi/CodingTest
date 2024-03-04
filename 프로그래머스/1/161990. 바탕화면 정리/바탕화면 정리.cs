using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int top = 50; int left = 50;
        int right = 0; int bottom = 0;
        
        for(int i = 0; i < wallpaper.Length; i++) {
            string temp = wallpaper[i];
            
            for(int j = 0; j < temp.Length; j++) {
                if(temp[j] == '#') {
                    top = top > i ? i : top;
                    left = left > j ? j : left;
                    right = right < j ? j : right;
                    bottom = bottom < i ? i : bottom;
                }
            }
        }
        int[] answer = new int[4] {top, left, bottom + 1, right + 1};
        
        return answer;
    }
}