#include <string>
#include <vector>

using namespace std;

int solution(int angle) {
    int answer = (angle <= 90) ? (angle < 90 ? 1 : 2) : (angle < 180 ? 3 : 4);
    return answer;
}