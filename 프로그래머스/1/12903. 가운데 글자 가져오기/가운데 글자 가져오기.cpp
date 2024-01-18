#include <string>
#include <vector>

using namespace std;

string solution(string s) {
    int n = (s.length() + 1) % 2;
    int l = s.length() / 2 - n;
    return s.substr(l, n + 1);
}