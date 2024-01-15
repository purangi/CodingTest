public class Solution {
    public bool solution(int x) {
        bool answer = true;
        
        int origin = x;
        int sum = 0;
        while(x > 0) {
            sum += x % 10;
            x /= 10;
        }
        
        answer = origin % sum == 0 ? true : false;
        return answer;
    }
}