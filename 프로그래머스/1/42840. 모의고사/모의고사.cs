using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        
        int[] one = new int[] {1, 2, 3, 4, 5};
        int[] two = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] three = new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        
        int[] score = new int[] {0, 0, 0};
        
        for(int i = 0; i < answers.Length; i++) {
            if(answers[i] == one[i % one.Length]) score[0]++;
            if(answers[i] == two[i % two.Length]) score[1]++;
            if(answers[i] == three[i % three.Length]) score[2]++;
        }
        
        int max = score.Max();
        
        List<int> temp = new List<int>();
        for(int i = 0; i < score.Length; i++) {
            if(max == score[i]) {
                temp.Add(i + 1);
            }
        }
        
        answer = temp.ToArray();
        return answer;
    }
}