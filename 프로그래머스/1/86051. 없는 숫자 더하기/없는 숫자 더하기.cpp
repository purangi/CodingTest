#include <string>
#include <vector>

using namespace std;

int solution(vector<int> numbers) {
    int answer = 45; //1부터 9까지 더한 수
    
    for(int i = 0; i < numbers.size(); i++) {
        answer -= numbers[i];
    }
    return answer;
}