#include <string>
#include <vector>
using namespace std;

int solution(string my_string, string is_suffix) {
    int l = is_suffix.size();
    if (l>my_string.size()){
        return 0;
    }
    string substring = my_string.substr(my_string.size()-l,l);
    if (is_suffix==substring){
        return 1;
    }
    return 0;
}