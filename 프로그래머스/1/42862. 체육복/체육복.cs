using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        
        List<int> listLost = new List<int>(lost);
        List<int> listReserve = new List<int>(reserve);
        
        listLost.Sort();
        listReserve.Sort();
        
        List<int> temp = new List<int>(listReserve);
        
        for(int i = 0; i < temp.Count; i++) {
            if(listLost.Contains(temp[i])) {
                listLost.Remove(temp[i]);
                listReserve.Remove(temp[i]);
            }
        }
        
        for(int i = 0; i < listReserve.Count; i++) {
            if(listLost.Contains(listReserve[i] - 1)){
                listLost.Remove(listReserve[i] - 1);
                continue;
            }
            
            if(listLost.Contains(listReserve[i] + 1)){
                listLost.Remove(listReserve[i] + 1);
                continue;
            }
        }
        
        answer = n - listLost.Count;
        return answer;
    }
}