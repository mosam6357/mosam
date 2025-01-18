#include <iostream>
using namespace std;

int main(){
    int lim,n,a,cnt=0;
    cin >> lim >> n;
    for (int i=0;i<n;i++){
        cin >> a;
        cnt+=a;
    }
    cout << (n+1)*lim-cnt;
}