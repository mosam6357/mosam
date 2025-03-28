#include <iostream>
using namespace std;

int main(void){
    int a,b,n;
    cin >> a >> b;
    n = a;
    for (int i=0;i<b;i++){
        n*=10;
        a+=n;
    }
    cout << a;
    return 0;
}