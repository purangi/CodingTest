using System;
using System.Collections.Generic;

public class Solution {
    int[] num = new int[10];
    Stack<int> stk = new Stack<int>();
    
    public int solution(string numbers) {
        int answer = 0;
        
        int len = numbers.Length;
        
        for(int i = 0; i < numbers.Length; i++) {
            num[numbers[i] - '0']++;
        }
        
        for(int i = 1; i <= len; i++) {
            per(num, i, 0, 0);
        }
        
        answer = stk.Count;
        return answer;
    }
    
    bool isPrime(int n) {
        if(n == 2)
            return true;
        if(n <= 1 || n % 2 == 0)
            return false;
        for(int i = 3; i <= Math.Sqrt((float)n); i += 2)
            if(n % i == 0)
                return false;
        return true;
    }
    
    void per(int[] arr, int des, int n, int sum) {
        if(des == n && isPrime(sum)) {
            if(!stk.Contains(sum)) stk.Push(sum);
        } else {
            for(int i = 0; i < 10; i++) {
                if(arr[i] > 0) {
                    arr[i]--;
                    int ten = 1;
                    for(int j = 0; j < des - n - 1; j++) {
                        ten *= 10;
                    }
                    
                    per(arr, des, n+1, sum + (i * ten));
                    arr[i]++;
                }
            }
        }
    }
}