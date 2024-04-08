using System;
using System.Text;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        string str = "";
        if(k == 2 || k == 8 || k == 10)
            str = Convert.ToString(n, k);
        else
        {
            long temp = 0;
            while(n >= k)
            {
                str = (n % k).ToString() + str;
                n /= k;
            }
            str = n.ToString() + str;
        }
        string[] numbers = str.Split('0');

        for(int idx = 0; idx < numbers.Length; idx++)
        {
            long num = 0;
            bool isDigit = long.TryParse(numbers[idx], out num);
            if (!isDigit) continue;

            bool isPrime = num < 2 ? false : true;
            int max = (int)Math.Sqrt(num);
            for(int i = 3; i <= max; i += 2)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                    break;
                }   
            }
            if(isPrime)
                answer++;
        }
        return answer;
    }
}