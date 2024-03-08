using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        report = report.Distinct().ToArray();
        
        Dictionary<string, List<string>> reportedIDs = new Dictionary<string, List<string>>();
        Dictionary<string, int> reportedCnt = new Dictionary<string, int>();
        
        for(int i = 0; i < report.Length; i++) {
            string[] splitedReport = report[i].Split(' ');
            string reportID = splitedReport[0];
            string reportedID = splitedReport[1];
            
            if(reportedIDs.ContainsKey(reportID))
                reportedIDs[reportID].Add(reportedID);
            else
            reportedIDs.Add(reportID, new List<string> {reportedID});
            
            if(reportedCnt.ContainsKey(reportedID))
                reportedCnt[reportedID]++;
            else
                reportedCnt.Add(reportedID, 1);
        }
        
        List<int> answerList = new List<int>();
        
        for(int i = 0; i < id_list.Length; i++) {
            int cnt = 0;
            
            if(reportedIDs.ContainsKey(id_list[i])) {
                for(int j = 0; j < reportedIDs[id_list[i]].Count; j++) {
                    string reportedID = reportedIDs[id_list[i]][j];
                    if(reportedCnt.ContainsKey(reportedID)) {
                        if(reportedCnt[reportedID] >= k) {
                            cnt++;
                        }
                    }
                }
            }
            
            answerList.Add(cnt);
        }
        
        return answerList.ToArray();
    }
}