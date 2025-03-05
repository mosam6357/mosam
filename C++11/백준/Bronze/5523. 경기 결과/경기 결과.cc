#include <iostream>
using namespace std;

int main(void){
    int a,n1,n2,cnt1=0,cnt2=0;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> n1 >> n2;
        if (n1>n2){
            cnt1++;
        }
        else if(n1<n2){
            cnt2++;
        }
    }
    cout << cnt1 << " " << cnt2;
    return 0;
}