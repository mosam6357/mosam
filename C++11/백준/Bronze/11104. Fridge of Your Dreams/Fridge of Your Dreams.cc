#include <iostream>
using namespace std;
int main(){
    int a;
    cin >> a;
    for (int i=0; i<a; i++){
        string b;
        cin >> b;
        int ans = 0;
        int twice = 1;
        for (int j=0; j<24; j++){
            if(b[23-j]=='1'){
                ans+=twice;
            }
            twice*=2;
        }
        cout << ans << endl;
    }
}