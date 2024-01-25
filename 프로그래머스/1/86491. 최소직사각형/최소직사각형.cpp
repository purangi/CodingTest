#include <string>
#include <vector>

using namespace std;

int solution(vector<vector<int>> sizes) {
    int answer = 0;
    
    int maxX = 0;
    int maxY = 0;
    for(int i = 0; i < sizes.size(); i++) {
        vector<int> cur = sizes[i];
        
        if(cur[0] < cur[1]) {
            int temp = cur[0];
            cur[0] = cur [1];
            cur[1] = temp;
        }
        
        if(cur[0] > maxX) maxX = cur[0];
        if(cur[1] > maxY) maxY = cur[1];
    }
    
    answer = maxX * maxY;
    return answer;
}