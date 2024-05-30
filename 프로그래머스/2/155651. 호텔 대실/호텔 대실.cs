using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    int NormalizedTime(string time) {
        string[] splittedTime = time.Split(':');
        int hour = int.Parse(splittedTime[0]);
        int min = int.Parse(splittedTime[1]);
        
        return hour * 60 + min;
    }
    
    public int solution(string[,] book_time) {
        int answer = 0;
        
        var timeList = new List<(int start, int end)>();
        
        for(int i = 0; i < book_time.GetLength(0); i++) {
            int start = NormalizedTime(book_time[i, 0]);
            int end = NormalizedTime(book_time[i,1]);
            timeList.Add((start, end));
        }
        
        var sorted = timeList.OrderBy(o => o.Item1);
        var roomList = new List<int>();
        
        foreach((int start, int end) t in sorted) {
            int room = roomList.FindIndex(f => f <= t.start - 10);
            if(room == -1) roomList.Add(t.end);
            else roomList[room] = t.end;
        }
        
        answer = roomList.Count;
        return answer;
    }
}