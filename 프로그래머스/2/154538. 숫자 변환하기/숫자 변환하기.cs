using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int x, int y, int n) {
        int answer = 0;
        
        List<int> targets = new List<int>() {x};
        List<int> results = new List<int>();
        
        HashSet<int> sames = new HashSet<int>();
        
        while(targets.Count > 0){
            if(targets.Contains(y)) 
                return answer;
            
            answer++;
            results.Clear();
            
            foreach(int item in targets) {
                sames.Add(item);
                int a = item + n;
                int b = item * 2;
                int c = item * 3;
                
                if(a <= y && sames.Contains(a) == false)
                    results.Add(a);
                
                if(b <= y && sames.Contains(b) == false) 
                    results.Add(b);
                
                if(c <= y && sames.Contains(c) == false)
                    results.Add(c);
            }
            
            List<int> temp = targets;
            targets = results;
            results = temp;
        }
        
        
        return -1;
    }
}