public class Solution {
    int LCM(int a, int b) {
        int x = a * b;
        int temp = 0;
        
        while(b > 0) {
            temp = a % b;
            a = b;
            b = temp;
        }
        
        return x / a;
    }
    public int solution(int[] arr) {
        int answer = LCM(arr[0], arr[1]);
        
        for(int i = 2; i < arr.Length; i++) {
            answer = LCM(answer, arr[i]);
        }
        
        return answer;
    }
}