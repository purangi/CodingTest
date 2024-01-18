using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long sumPrice = 0;
        
        for(int i = 1; i <= count; i++) {
            sumPrice += price * i;
        }
        
        return sumPrice < money ? 0 : sumPrice - money;
    }
}