using System;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        
       var list = tangerine.ToList().GroupBy(g => g).Select(x => new{size = x.Key, cnt = x.Count()}).OrderByDescending(x => x.cnt);

			int typeCnt = 0;
			int tangCnt = 0;
			foreach(var item in list)
			{
				typeCnt++;
				tangCnt += item.cnt;
				if (k <= tangCnt)
				{
					return typeCnt;
				}
			}
        return 0;
    }
}