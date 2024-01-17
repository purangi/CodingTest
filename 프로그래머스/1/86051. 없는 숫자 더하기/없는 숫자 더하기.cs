using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45; //1부터 9까지 더한 수
        
        for(int i = 0; i < numbers.Length; i++) {
            answer -= numbers[i];
        }
        return answer;
    }
}