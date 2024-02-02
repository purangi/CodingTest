using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
    
        while(n >= a) {
            int remainder = n % a;
            n = (n / a) * b;
            answer += n;
            n += remainder;
        }
        return answer;
    }
}