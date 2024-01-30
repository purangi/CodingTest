using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> answer = new List<int>();
        
        for(int i = 0; i < numbers.Length;i++) {
            for(int j = i + 1; j < numbers.Length; j++) {
                int temp = numbers[i] + numbers[j];
                if(answer.Contains(temp)) continue;
                answer.Add(temp);
            }
        }
        
        answer.Sort();
        
        return answer.ToArray();
    }
}