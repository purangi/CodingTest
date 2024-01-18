using System;
using System.Linq;

public class Solution {
    public int solution(int[] a, int[] b) {
        //int answer = 0;
        return a.Select((t,idx) => t * b[idx]).Sum();
    }
}