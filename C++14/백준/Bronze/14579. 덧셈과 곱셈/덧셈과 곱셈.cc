#include <iostream>
using namespace std;

int main(void){
    int a,b,n=1;
    cin >> a >> b;
    for (int i=a;i<=b;i++){
        n*=(i*(i+1)/2);
        n%=14579;
    }
    cout << n;
    return 0;
}