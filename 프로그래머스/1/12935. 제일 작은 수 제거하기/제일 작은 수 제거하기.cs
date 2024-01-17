using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int min = arr.Min();
        
        List<int> answer = new List<int>();
        
        for(int i = 0; i < arr.Length; i++) {
            if(arr[i] != min) answer.Add(arr[i]);
        }
        
        if(answer.Count == 0) answer.Add(-1);
        
        return answer.ToArray();
    }
}