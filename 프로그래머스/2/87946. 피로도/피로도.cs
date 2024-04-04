using System;

public class Solution {
    int answer = 0;
    public int solution(int k, int[,] dungeons) {
        bool[] visit = new bool[dungeons.Length];
        answer = Recursive(k, dungeons, visit, 0);
        
        return answer;
    }
    
    public int Recursive(int k, int[,] dungeons, bool[] visit, int cnt) {
        for(int i = 0; i < dungeons.GetLength(0); i++) {
            if(k >= dungeons[i, 0] && !visit[i]) {
                visit[i] = true;
                Recursive(k - dungeons[i,1], dungeons, visit, cnt + 1);
                visit[i] = false;
            }
        }
        
        answer = Math.Max(cnt, answer);
        return answer;
    }
}