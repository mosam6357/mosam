#include <iostream>
using namespace std;

int main(void){
    int a,b,n;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b;
        n = (b+1)/2;
        cout << n*n << '\n';
    }
    return 0;
}