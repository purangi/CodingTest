using System;
using System.Collections;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        
        Queue queue = new Queue();
        
        int index = 0;
        foreach(int i in priorities) {
            queue.Enqueue(index++ + "," + i);
        }
        
        while(queue.Count != 0) {
            string[] qSplit = queue.Dequeue().ToString().Split(',');
            int qIndex = int.Parse(qSplit[0]);
            int value = int.Parse(qSplit[1]);
            
            if(check(value, priorities))
                queue.Enqueue(qIndex + "," + value);
            else {
                answer++;
                priorities[qIndex] = -1;
                if(qIndex == location) break;
            }
        }
        
        return answer;
    }
    
    bool check(int value, int[] priorities) {
        foreach(int i in priorities)
            if (value < i) return true;
        
        return false;
    }
}