using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>();
        DateTime dt = DateTime.Parse(today);
        
        Dictionary<string, string> termsDic = new Dictionary<string, string>();
        
        for(int i = 0; i < terms.Length; i++) {
            string[] s = terms[i].Split(" ");
            termsDic.Add(s[0], s[1]);
        }
        
        for (int i = 0; i < privacies.Length; i++) {
            string[] s = privacies[i].Split(" ");
            
            if(termsDic.TryGetValue(s[1], out string value)) {
                DateTime privacy = DateTime.Parse(s[0]).AddMonths(int.Parse(value));
                
                if(dt.CompareTo(privacy) != -1) {
                    answer.Add(i + 1);
                }
            }
        }
        
        answer.Sort();
        
        return answer.ToArray();
    }
}