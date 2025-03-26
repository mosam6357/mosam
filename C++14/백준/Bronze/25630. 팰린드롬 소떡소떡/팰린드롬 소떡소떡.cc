#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,cnt=0;
    string s;
    cin >> a >> s;
    for (int i=0;i<a;i++){
        if(s[i]!=s[a-1-i]){
            cnt++;
        }
    }
    cout << cnt/2;
    return 0;
}