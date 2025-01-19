#include <iostream>
using namespace std;

int main(){
    long a,ans = 5;
    cin >> a ;
    for (int i=0;i<a;i++){
        if (i!=0){
            ans+=(i+2)*3-2;
        }
    }
    cout << ans%45678;
}