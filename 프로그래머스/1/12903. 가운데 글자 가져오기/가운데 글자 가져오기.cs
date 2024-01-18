public class Solution {
    public string solution(string s) {
        string answer = "";
        answer = s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) :s.Substring(s.Length / 2, 1);
        return answer;
    }
}