using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] nums = s.Split(" ");
        
        List<int> list = new List<int>();
        foreach(string n in nums) {
            int.TryParse(n, out int result);
            list.Add(result);
        }
        
        answer += list.Min() + " " + list.Max();
        return answer;
    }
}