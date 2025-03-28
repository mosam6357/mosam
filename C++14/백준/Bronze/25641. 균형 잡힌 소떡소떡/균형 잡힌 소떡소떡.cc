#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,cnt=0,l;
    string s;
    cin >> a >> s;
    for (int i=a-1;i>=0;i--){
        if (s[i]=='s'){
            cnt++;
        }
        else{
            cnt--;
        }
        if (cnt==0){
            l = a-i;
        }
    }
    cout << s.substr(a-l,l);
    return 0;
}