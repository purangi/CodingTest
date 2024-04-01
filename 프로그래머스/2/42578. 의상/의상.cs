using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        Dictionary<string, int> clothesDic = new Dictionary<string, int>();
        
        for(int i = 0; i < clothes.GetLength(0); i++) {
            string type = clothes[i, 1];
            if(clothesDic.ContainsKey(type)) {
                clothesDic[type]++;
            } else {
                clothesDic[type] = 1;
            }
        }
        
        foreach(var count in clothesDic.Values) {
            answer *= (count + 1);
        }
        
        return answer - 1;
    }
}