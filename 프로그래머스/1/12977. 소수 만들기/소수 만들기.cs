using System;

class Solution
{
    bool isPrime(int n) {
        for(int i = 2; i < n; i++) {
            if(n % i == 0) return false;
        }
        
        return true;
    }
    
    public int solution(int[] nums)
    {
        int answer = 0;

        for(int i = 0; i < nums.Length; i++) {
            for(int j = i + 1; j < nums.Length; j++) {
                for(int k = j + 1; k < nums.Length; k++) {
                    int sum = nums[i] + nums[j] + nums[k];
                    if(isPrime(sum)) answer++;
                }
            }
        }
        

        return answer;
    }
}