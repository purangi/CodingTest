using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = new string(s.ToCharArray().OrderByDescending(x => x).ToArray());
        
        return answer;
    }
}