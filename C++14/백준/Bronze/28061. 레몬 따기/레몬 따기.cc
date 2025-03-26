#include <iostream>
using namespace std;

int main(void){
    int a,b,m=0;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b;
        b-=a-i;
        m=m>b?m:b;
    }
    cout << m;
    return 0;
}