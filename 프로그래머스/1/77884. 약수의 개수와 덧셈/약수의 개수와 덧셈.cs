using System;

public class Solution {
    public bool divisor(int num){
        int cnt = 0;
        for(int i = 1; i <= num; i++) {
            if(num % i == 0) cnt++;
        }
        
        bool answer = cnt % 2 == 0 ? true : false;
        return answer;
    }
    
    public int solution(int left, int right) {
        int answer = 0;
        
        for(int i = left; i <= right; i++) {
            answer += divisor(i) ? i : -i;
        }
        
        return answer;
    }
}