#include <string>
#include <vector>
#include <regex>

using namespace std;

int solution(string s) {
    vector<string> numStr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    
    regex r;
    for(int i = 0; i < numStr.size(); i++) {
        r = numStr[i];
        s = regex_replace(s, r, to_string(i));
    }
    return stoi(s);
}