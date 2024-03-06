using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        
        for(int i = 0; i < players.Length; i++) {
            dic.Add(players[i], i);
        }
        
        foreach(string call in callings) {
            int order = dic[call];
            string temp = players[order - 1];
            
            players[order - 1] = call;
            players[order] = temp;
            
            dic[call] = order - 1;
            dic[temp] = order;
        }
        
        return players;
    }
}