public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        if(s[0] == '+') {
            string splitStr = s.Substring(1);
            answer = int.Parse(splitStr);
        } else if(s[0] == '-') {
            string splitStr = s.Substring(1);
            answer = int.Parse(splitStr);
            answer *= -1;
        } else {
            answer = int.Parse(s);
        }
        return answer;
    }
}