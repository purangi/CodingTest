using System;

public class Solution {
    public long solution(long n) {
        double s = Math.Sqrt(n);
        
        if(s % 1 == 0) {
            return (long) (s+1) * (long) (s+1);
        } else {
            return -1;
        }
    }
}