#include <string>
#include <vector>

using namespace std;

vector<string> solution(string my_string) {
    vector<string> answer;
    string a = "";
    for (int i=0;i<my_string.size();i++){
        if (my_string[i]==' '){
            answer.push_back(a);
            a = "";
        }
        else{
            a+=my_string[i];
        }
    }
    answer.push_back(a);
    return answer;
}