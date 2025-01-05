#include <iostream>
using namespace std;

int main(){
    int a,b,cnt=0;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b;
        cnt+=b!=1?1:0;
    }
    cout << cnt;
}