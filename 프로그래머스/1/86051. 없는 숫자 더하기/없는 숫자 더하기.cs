using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        /*
        int answer = 45; //1부터 9까지 더한 수
        
        for(int i = 0; i < numbers.Length; i++) {
            answer -= numbers[i];
        }*/
        
        return 45 - numbers.Sum();
    }
}