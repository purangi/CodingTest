using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        List<int> answer = new List<int>();

        int defTime = fees[0];
        int defPrice = fees[1];
        int unitTime = fees[2];
        int unitPrice = fees[3];

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        for (int i = 0; i < records.Length; i++)
        {
            string[] strArr = records[i].Split(" ");
            string CarNumber = strArr[1];

            if (dic.ContainsKey(CarNumber) == false)
                dic.Add(CarNumber, records.Where(w => w.Contains(CarNumber)).OrderBy(o => o).ToList());
        }

        var sortDic = dic.OrderBy(o => o.Key);

        foreach (var item in sortDic)
        {
            int startT = 0;
            int endT = 0;

            int totalT = 0;
            for (int i = 0; i < item.Value.Count; i++)
            {
                string[] strArr = item.Value[i].Split(" ");
                string[] times = strArr[0].Split(":");
                int time = int.Parse(times[0]) * 60 + int.Parse(times[1]);
                string type = strArr[2];

                if (type.Equals("IN"))
                {
                    startT = time;
                }
                else
                {
                    totalT += time - startT;
                }
            }

            if (item.Value.Count % 2 == 1)
            {
                totalT += (24 * 60) - startT - 1;
            }

            int price = defPrice;
            if (defTime < totalT)
            {
                price += (((totalT - defTime) / unitTime)) * unitPrice;

                if (((totalT - defTime) % unitTime) != 0)
                    price += unitPrice;
            }

            answer.Add(price);
        }
        return answer.ToArray();
    }
}