#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> num_list) {
    vector<int> answer;
    int l = num_list.size();
    for (int i=0;i<l;i++){
        answer.push_back(num_list[i]);
    }
    if (num_list[l-1]>num_list[l-2]){
        answer.push_back(num_list[l-1]-num_list[l-2]);
    }
    else{
        answer.push_back(num_list[l-1]*2);
    }
    return answer;
}