using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        string s = n.ToString();
        char[] c = s.ToCharArray();
        Array.Sort(c);
        Array.Reverse(c);
        answer = long.Parse(new string(c));
        return answer;
    }
}