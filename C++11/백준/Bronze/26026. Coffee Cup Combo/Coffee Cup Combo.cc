#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,c=0,cnt=0;
    string s;
    cin >> a >> s;
    for (int i=0;i<a;i++){
        if (s[i]=='1'){
            c = 3;
        }
        if (c>0){
            cnt++;
            c--;
        }
    }
    cout << cnt;
}