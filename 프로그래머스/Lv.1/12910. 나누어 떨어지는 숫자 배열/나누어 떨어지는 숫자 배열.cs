using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> answerList = new List<int>();

        foreach(int i in arr) {
            if(i % divisor == 0) answerList.Add(i);
        }
        
        if(answerList.Count == 0) answerList.Add(-1);
        else answerList.Sort();
        return answerList.ToArray();
    }
}