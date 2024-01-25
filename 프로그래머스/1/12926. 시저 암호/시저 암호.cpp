#include <string>
#include <vector>

using namespace std;

string solution(string s, int n) {
    string answer = "";
    
    int a = 0;
    for(int i = 0; i < s.length(); i++) {
        if(s[i] == ' ') {
            answer += " ";
        } else {
            int start = isupper(s[i]) ? 'A' : 'a';
            answer += start + (s[i]-start + n)%26;
        }
    }
    return answer;
}