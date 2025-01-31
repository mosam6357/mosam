#include <iostream>
#include <string>
using namespace std;

int main(){
    int a,b;
    cin >> a >> b;
    int aa[10] = {0,};
    for (int i=a;i<=b;i++){
        string s = to_string(i);
        for (int j=0;j<s.length();j++){
            aa[s[j]-'0']++;
        }
    }
    for (int i=0;i<10;i++){
        cout << aa[i] << " ";
    }
    return 0;
}