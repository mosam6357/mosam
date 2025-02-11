#include <iostream>
#include <string>
using namespace std;

int main(){
    int ck = 0;
    string s;
    cin >> s;
    for (int i=0;i<s.length();i++){
        if (s[i]=='-'){
            ck=0;
        }
        else if(ck==0){
            cout << s[i];
            ck = 1;
        }
    }
    return 0;
}