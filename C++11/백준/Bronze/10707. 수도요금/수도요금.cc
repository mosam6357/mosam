#include <iostream>
using namespace std;

int main(void){
    int a,b,c,d,p,c1,c2;
    cin >> a>>b>>c>>d>>p;
    c1 = a*p;
    c2 = b;
    if (p>c){
        c2+=(p-c)*d;
    }
    cout << (c1<c2?c1:c2);
    return 0;
}