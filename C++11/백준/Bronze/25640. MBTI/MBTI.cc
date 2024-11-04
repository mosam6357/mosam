#include <iostream>
using namespace std;

int main(){
    string s1;
    int a;
    int cnt = 0;
    cin >> s1 >> a;
    for (int i =0; i<a; i++){
        string s2;
        cin >> s2;
        if(s1==s2)cnt++;
    }
    cout << cnt;
}