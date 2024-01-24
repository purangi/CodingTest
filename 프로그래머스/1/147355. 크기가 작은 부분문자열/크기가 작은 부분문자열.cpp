#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(string t, string p) {
    int answer = 0;
    
    long longP = stol(p);
    for(int i = 0; i <= t.size() - p.size(); i++) {
        string temp = t.substr(i, p.size());
        long longT = stol(temp);
        if(longT <= longP) answer++;
    }
    
    return answer;
}