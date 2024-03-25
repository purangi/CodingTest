using System;

public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        int[] elementsArr = new int[elements.Length * 1000 + 1];
        
        for(int i = 1; i <= elements.Length; i++) {
            for(int j = 0; j < elements.Length; j++) {
                int idx = 0; 
                for(int k = 0; k < i; k++) {
                    idx += elements[(j + k) % elements.Length];
                }
                if(elementsArr[idx] == 0) {
                    elementsArr[idx] = 1;
                    answer++;
                }
            }
        }
        return answer;
    }
}