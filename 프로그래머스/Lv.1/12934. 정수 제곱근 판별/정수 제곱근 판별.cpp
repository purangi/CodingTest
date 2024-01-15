#include <string>
#include <vector>
#include <cmath>
using namespace std;

long long solution(long long n) {
    long long answer = 0;
    long s = sqrt(n);
    
    answer = (s * s == n) ? (s+1) * (s+1) : -1;
    return answer;
}