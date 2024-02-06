public class Solution {
    public string solution(int a, int b) {
        string[] day = new string[] {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        int[] month = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        int cnt = b - 1;
        for(int i = 0; i < a - 1; i++) {
            cnt += month[i];
        }
        
        
        string answer = day[cnt % 7];
        return answer;
    }
}