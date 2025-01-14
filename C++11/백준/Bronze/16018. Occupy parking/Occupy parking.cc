#include <iostream>
#include <string>
using namespace std;

int main(){
    int n,cnt =0;
    string a,b;
    cin >> n >> a >> b;
    for (int i=0;i<n;i++){
        if (a[i]==b[i] && a[i]=='C')cnt++;
    }
    cout << cnt;
}