#include <string>
#include <vector>
#include <algorithm>

using namespace std;

vector<int> solution(int k, vector<int> score) {
    vector<int> answer, honors;
    
    for(int i = 0; i < score.size(); i++) {
        if(i < k) {
            honors.push_back(score[i]);
        } else {
            honors[k - 1] = honors[k - 1] < score[i] ? score[i] : honors[k - 1];
        }
        
        sort(honors.rbegin(), honors.rend());
        int temp = i < k ? honors[i] : honors[k-1];
        answer.push_back(temp);
    }
    
    return answer;
}