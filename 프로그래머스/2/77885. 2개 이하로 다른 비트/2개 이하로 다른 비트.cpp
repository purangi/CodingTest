#include <string>
#include <vector>
 
using namespace std;
 
vector<long long> solution(vector<long long> numbers)
{
    vector<long long> answer;
 
    for (int i = 0; i < numbers.size(); i++)
    {
        if (numbers[i] & 1)
        {
            for (int j = 0; j < 64; j++)
                if (!(numbers[i] & ((long long)1 << j)))
                {
                    answer.push_back(numbers[i] + ((long long)1 << (j - 1)));
                    break;
                }
        }
        else answer.push_back(numbers[i] + 1);
    }
 
    return answer;
}