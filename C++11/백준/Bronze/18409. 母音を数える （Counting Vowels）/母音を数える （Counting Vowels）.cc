#include <iostream>
using namespace std;

int main(){
    int a;
    int cnt=0;
    string s;
    cin >> a >> s;
    for (int i =0; i<a; i++){
        if(s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u'){
            cnt++;
        }
    }
    cout << cnt;
}