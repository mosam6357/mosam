#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,cnt=0;
    string s;
    cin >> a >> s;
    for (int i=0;i<a;i++){
        if (s[i]=='2'){
            cnt++;
        }
        else{
            cnt--;
        }
    }
    if (cnt>0){
        cout << "2";
    }
    else if(cnt==0){
        cout << "yee";
    }
    else{
        cout << "e";
    }
    return 0;
}