#include <string>
#include <vector>

using namespace std;

vector<string> solution(vector<string> strArr) {
    vector<string> answer;
    for (int i=0;i<strArr.size();i++){
        string str = "";
        if (i%2==0){
            for (int j=0;j<strArr[i].size();j++){
                str+=tolower(strArr[i][j]);
            }
        }
        else{
            for (int j=0;j<strArr[i].size();j++){
                str+=toupper(strArr[i][j]);
            }
        }
        answer.push_back(str);
    }
    return answer;
}