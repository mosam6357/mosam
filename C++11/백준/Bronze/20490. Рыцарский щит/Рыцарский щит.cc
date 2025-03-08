#include <iostream>
using namespace std;

int main(void){
    int n,m1=0,m2=0,minm,total = 0;
    for (int i=0;i<3;i++){
        cin >> n;
        total+=n;
        m1 = m1>n?m1:n;
    }
    for (int i=0;i<3;i++){
        cin >> n;
        total+=n;
        m2 = m2>n?m2:n;
    }
    minm = m1<m2?m1:m2;
    cout << total-minm*2;
    return 0;
}