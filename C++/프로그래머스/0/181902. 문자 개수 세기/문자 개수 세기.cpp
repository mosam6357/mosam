#include <string>
#include <algorithm>
#include <vector>

using namespace std;

vector<int> solution(string my_string){
    vector<int> answer;
    int n = 65;
    for (int i=0;i<2;i++){
        for (int j=0;j<26;j++){
            answer.push_back(count(my_string.begin(),my_string.end(),(char)n));
            n++;
        }
            n+=6;    
     }
        return answer;
}