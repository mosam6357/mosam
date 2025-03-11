#include <iostream>
using namespace std;

int main(){
    int a,b,n,m1=0,m2=0;
    cin >> a >> b;
    for (int i=0;i<a;i++){
        cin >> n;
        m1 = m1>n?m1:n;
    }
    for (int i=0;i<b;i++){
        cin >> n;
        m2 = m2>n?m2:n;
    }
    cout << m1+m2;
    return 0;
}