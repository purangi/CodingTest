using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] order) {
        int answer = 0;
        
        Stack<int> stk = new Stack<int>();
        
        for(int i = 0; i < order.Length; i++) {
            int box = i + 1;
            if(box == order[answer])
                ++answer;
            else
                stk.Push(box);
            
            while(stk.Count > 0 && stk.Peek() == order[answer]) {
                stk.Pop();
                ++answer;
            }
        }
        return answer;
    }
}