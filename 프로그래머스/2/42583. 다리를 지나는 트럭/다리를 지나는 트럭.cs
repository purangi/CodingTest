using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        int answer = 0;
        int cnt = 0;
        int totalWeight = 0;
        int time = 0;
        
        Queue<int> q = new Queue<int>();
        
        while(true) {
            if(cnt == truck_weights.Length) break;
            
            if(q.Count == bridge_length) totalWeight -= q.Dequeue();
            
            if(totalWeight + truck_weights[cnt] <= weight) {
                totalWeight += truck_weights[cnt];
                q.Enqueue(truck_weights[cnt]);
                cnt++;
            } else {
                q.Enqueue(0);
            }
            
            time++;
        }
        
        answer = time + bridge_length;
        return answer;
    }
}