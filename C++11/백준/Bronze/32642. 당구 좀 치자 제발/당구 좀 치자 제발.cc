#include <iostream>
using namespace std;

int main(){
    int a;
    long long s = 0;
    long long ans = 0;
    cin >> a;
    for (int i =0; i<a; i++){
        int b;
        cin >> b;
        s+=b*2-1;
        ans+=s;
    }
    cout << ans;
}