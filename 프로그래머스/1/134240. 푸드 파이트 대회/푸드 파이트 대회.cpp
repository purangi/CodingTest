#include <string>
#include <vector>
#include <algorithm>

using namespace std;

string solution(vector<int> food) {
    string answer = "";
    
    string ans = "";
    for(int i = 1; i < food.size(); i++) {
        int cnt = food[i] / 2;
        for(int j = 0; j < cnt; j++) {
            ans += to_string(i);
        }
    }
        
    answer = ans + "0";
    reverse(ans.begin(), ans.end());
    answer += ans;
    
    return answer;
}