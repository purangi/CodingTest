using System;

public class Solution {
    int answer = 0;
    public int solution(int[] numbers, int target) {
        GetTarget(numbers, target, 0, 0);
        return answer;
    }
    
    void GetTarget(int[] numbers, int target, int sum, int index) {
        if(index == numbers.Length) {
            if(sum == target) answer++;
            return;
        }
        GetTarget(numbers, target, sum + numbers[index], index + 1);
        GetTarget(numbers, target, sum - numbers[index], index + 1);
        
    }
}