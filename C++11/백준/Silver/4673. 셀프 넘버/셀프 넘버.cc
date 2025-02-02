#include <iostream>
#include <string>
using namespace std;

int main(){
    int a[10000] = {0,};
    for (int i=1;i<=10000;i++){
        int n = i;
        string s = to_string(n);
        for (int j=0;j<s.length();j++){
            n+=s[j]-'0';
        }
        if (n<=10000){
            a[n-1]=1;
        }
    }
    for (int i=0;i<10000;i++){
        if (a[i]==0){
            cout << i+1 << endl;
        }
    }
    return 0;
}