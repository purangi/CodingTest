using System;

public class Solution {
    public int solution(int[,] sizes) {        
        int xMax = 0;
        int yMax = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++) {
            if(sizes[i, 0] < sizes[i,1]){
                int temp = sizes[i,1];
                sizes[i,1] = sizes[i,0];
                sizes[i,0] = temp;                
            }
            
            if(sizes[i,0] > xMax) xMax = sizes[i,0];
            if(sizes[i,1] > yMax) yMax = sizes[i,1];
        }
        
        return xMax * yMax;
    }
}