#include <iostream>
using namespace std;

int main(){
    int a,cnt = 0;
    cin >> a;
    char s1[a+1],s2[a+1];
    cin >> s1 >> s2;
    for (int i=0;i<a;i++){
        if(s1[i]!=s2[i])cnt++;
    }
    cout << cnt;
}