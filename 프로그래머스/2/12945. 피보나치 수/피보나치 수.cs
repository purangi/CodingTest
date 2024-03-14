public class Solution {
    public int solution(int n) {
        int answer = 0;
        int first = 0;
        int second = 1;
        
        for(int i=2; i<=n; i++)
        {
            answer = (first + second) % 1234567;
            first = second % 1234567 ;
            second = answer;
        }
        
        return answer;
    }
}