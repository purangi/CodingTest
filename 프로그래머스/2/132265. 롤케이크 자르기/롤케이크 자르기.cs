using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        
        Dictionary<int, int> leftDic = new Dictionary<int, int>();
        Dictionary<int, int> rightDic = new Dictionary<int, int>();
        
        for(int i = 0; i < topping.Length; i++) {
            if(rightDic.ContainsKey(topping[i])) {
                rightDic[topping[i]]++;
            } else{
                rightDic.Add(topping[i], 1);
            }
        }
        
        for(int i = 0; i < topping.Length; i++) {
            if(!leftDic.ContainsKey(topping[i])) {
                leftDic.Add(topping[i], 1);
            }
            
            if(rightDic[topping[i]] > 1) {
                rightDic[topping[i]]--;
            } else {
                rightDic.Remove(topping[i]);
            }
            
            if(leftDic.Keys.Count == rightDic.Keys.Count) {
                answer++;
            }
        }
        return answer;
    }
}