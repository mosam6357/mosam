#include <string>
#include <vector>

using namespace std;

int solution(int a, int b) {
    string s1 = to_string(a);
    string s2 = to_string(b);
    int answer = max(stoi(s1+s2),stoi(s2+s1));
    return answer;
}