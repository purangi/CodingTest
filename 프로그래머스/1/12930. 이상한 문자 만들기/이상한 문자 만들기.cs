public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] words = s.Split(' ');

        for(int i = 0; i < words.Length; i++) {
            string word = words[i];
            for(int j = 0; j < word.Length; j++) {
                answer += j % 2 == 0 ? char.ToUpper(word[j]) : char.ToLower(word[j]);
            }
            if(i != words.Length - 1) answer += " ";
        }
        return answer;
    }
}