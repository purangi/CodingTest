using System;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        int[] honors = new int[k];
        
        for(int i = 0; i < score.Length; i++) {
            honors[k - 1] = honors[k - 1] < score[i] ? score[i] : honors[k - 1];
            honors = honors.OrderByDescending(n => n).ToArray();
            answer[i] = i < k ? honors[i] : honors[k-1];
        }
        
        return answer;
    }
}