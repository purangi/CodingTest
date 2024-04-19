using System;

public class Solution 
{
    public long[] solution(long[] numbers) 
    {
        long[] answer = new long[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                answer[i] = numbers[i] + 1;
            }

            else
            { 
                long lastZero = (numbers[i] + 1) & (-numbers[i]);
                long zeroToOne = numbers[i] | lastZero;
                long temp = (zeroToOne & (~(lastZero) >> 1));

                answer[i] = temp;
            }
        }

        return answer;
    }
}
