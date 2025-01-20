#include <iostream>
#include <string>
using namespace std;

int main(){
    string n,a;
    int t;
    cin >> n >> t;
    for (int i=0;i<t;i++){
        cin >> a;
        int cnt1 = 0;
        int cnt2 = 0;
        for (int j=0;j<4;j++){
            for (int k =0;k<4;k++){
                if(a[j]==n[k]){
                    cnt1++;
                    break;
                }
            }
            if(a[j]==n[j]){
                cnt2++;
            }
        }
        cout << cnt1 << " " << cnt2 << endl;
    }
}