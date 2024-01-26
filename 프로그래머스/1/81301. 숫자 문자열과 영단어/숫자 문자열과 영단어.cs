using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string[] numStr = new string[10] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        for(int i = 0; i < numStr.Length; i++) {
            s = s.Replace(numStr[i], i.ToString());
        }
        
        answer = int.Parse(s);
        return answer;
    }
}