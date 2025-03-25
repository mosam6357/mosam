#include <iostream>
using namespace std;

int main(void){
    long k,n,x;
    cin >> k >> n;
    if (n==1){
        cout << -1;
    }
    else{
        x = (n*k)/(n-1);
        if ((x-k)*n>=x){
            cout << x;
        }
        else{
            cout << x+1;
        }
    }
}