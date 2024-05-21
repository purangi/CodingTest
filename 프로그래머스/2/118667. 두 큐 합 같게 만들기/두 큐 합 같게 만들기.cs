using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        var q1 = new Queue<long>(queue1.Select(s=>(long)s)); 
        var q2 = new Queue<long>(queue2.Select(s=>(long)s)); 
        
        long sum1 = q1.Sum();
        long sum2 = q2.Sum();

        if(sum1 == sum2) return 0;
        
        long sum = sum1 + sum2;
        if(sum % 2 == 1) return -1;

        
        int maxTryCount = queue1.Length * 3;
        long target = sum /(long) 2;
        int answer = 0;
        while(sum1 != target)
        {
            if(answer > maxTryCount)
                return -1;

            if(sum1 < target)
            {
                long num = q2.Dequeue();
                q1.Enqueue(num);
                sum1 += num;
                answer++;
            }
            else
            {
                long num = q1.Dequeue();
                q2.Enqueue(num);
                sum1 -= num;
                answer++;
            }
        }
        return answer;
    }
}