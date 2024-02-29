using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        Dictionary<string, int> dic = new Dictionary<string, int>() {
            {"R", 0}, {"T", 0}, {"C", 0}, {"F", 0}, {"J", 0}, {"M", 0}, {"A", 0}, {"N", 0}
        };
        
        string s = "";
        int choice = 0;
        
        for(int i = 0; i < survey.Length; i++) {
            if(choices[i] > 4) {
                s = survey[i][1].ToString();
                choice = (4 - choices[i]) * -1;
            } else {
                s = survey[i][0].ToString();
                choice = 4 - choices[i];
            }
            
            dic[s] += choice;
        }
        
        answer += (dic["R"] >= dic["T"]) ? "R" : "T";
        answer += (dic["C"] >= dic["F"]) ? "C" : "F";
        answer += (dic["J"] >= dic["M"]) ? "J": "M";
        answer += (dic["A"] >= dic["N"]) ? "A" : "N";
        
        return answer;
    }
}