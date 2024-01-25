public class Solution {
    public string solution(string s, int n) {
        char[] sArray = s.ToCharArray();
        
        for(int i = 0; i < sArray.Length; i++) {
            if(sArray[i] == ' ') continue;
            
            int a = (sArray[i] >= 'A' && sArray[i] <= 'Z') ? (sArray[i] + n > 'Z' ? sArray[i] - ('Z' - 'A' + 1) : sArray[i]) : (sArray[i] + n > 'z' ? sArray[i] - ('z' - 'a' + 1) : sArray[i]);
            
            sArray[i] = (char) (a + n);
        }
        
        return new string(sArray);
    }
}