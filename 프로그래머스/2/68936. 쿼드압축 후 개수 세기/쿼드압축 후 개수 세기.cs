using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    private List<int> answer = new List<int>();
    public int[] solution(int[,] arr) {
        Zip(arr, 0, 0, arr.GetLength(0));
        
        
        return new int[] {answer.Count(i => i == 0), answer.Count(i => i == 1)};
    }
    
    void Zip(int[,] arr, int x, int y, int len) {
        if(len == 1) {
            answer.Add(arr[x,y]);
            return;
        }
        
        int num = arr[x,y];
        for(int i = x; i < x + len; i++) {
            for(int j = y; j < y + len; j++) {
                if(arr[i,j] != num) {
                    int temp = len / 2;
                    Zip(arr, x, y, temp);
                    Zip(arr, x, y + temp, temp);
                    Zip(arr, x + temp, y, temp);
                    Zip(arr, x + temp, y + temp, temp);
                    return;
                }
            }
        }
        
        answer.Add(num);
    }
}