#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,b,l=0,n=0;
    string s;
    cin >> a >> b;
    for (int i=0;i<a;i++){
        int cnt = 0;
        cin >> s;
        for (int j=0;j<b;j++){
            if (s[j]=='1' && (j==0 || s[j-1]=='0')){
                cnt++;
            }
        }
        if (cnt>l){
            l=cnt;
            n=1;
        }
        else if(cnt==l){
            n++;
        }
    }
    cout << l << " " << n;
    return 0;
}