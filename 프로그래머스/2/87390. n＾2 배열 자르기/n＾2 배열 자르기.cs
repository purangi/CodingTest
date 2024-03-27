using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[right - left + 1];
        
        int num = 0;
        
        for(long i = left / n; ++i <= n;) {
            if(num == answer.Length) break;
            
            long index = 0;
            if(i == left / n + 1)
                index = left % n;
            
            for(long j = index; ++j <= n;) {
                int temp = (int) j;
                if(temp < (int) i)
                    temp = (int) i;
                
                answer[num++] = temp;
                if(num == answer.Length)
                    break;
            }
        }
        return answer;
    }
}