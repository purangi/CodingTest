using System;

public class Solution {
    int Divisor(int num) {
        int cnt = 0;
        for(int i = 1; i *i <= num; i++) {
            if(num % i == 0) {
                cnt++;
                
                if(i*i < num) cnt++;
            }
        }
        
        return cnt;
    }
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i = 1; i <= number; i++) {
            int temp = Divisor(i);
            if(temp > limit) answer += power;
            else answer += temp;
        }
        
        return answer;
    }
}