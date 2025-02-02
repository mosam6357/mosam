#include <iostream>
using namespace std;

int main(){
    int t,a,b;
    cin >> t;
    for (int i=0;i<t;i++){
        cin >> a >> b;
        long ans = 1;
        for (int j=0;j<a;j++){
            ans*=b-j;
            ans/=j+1;
        }
        cout << ans << endl;
    }
}