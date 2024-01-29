using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for(int i = 0; i < commands.GetLength(0); i++) {
            int _i = commands[i, 0];
            int _j = commands[i, 1];
            int _k = commands[i, 2];
            
            int[] newArray = array.Skip(_i - 1).Take(_j - _i + 1).OrderBy(a => a).ToArray();
            
            answer[i] = newArray[_k - 1];
        }
        
        return answer;
    }
}