public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        
        int min, max;
        if(n >= m) {
            max = n;
            min = m;
        } else {
            max = m;
            min = n;
        }
        
        for(int i = 1; i <= min; i++) {
            if(n % i == 0 && m % i == 0) {
                answer[0] = i;
            } else {
                continue;
            }
        }
        
        for(int i = min; i <= m * n; i++) {
            if(i % n == 0 && i % m == 0) {
                answer[1] = i;
                break;
            } else {
                continue;
            }
        }
        
        return answer;
    }
}