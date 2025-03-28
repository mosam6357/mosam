#include <iostream>
using namespace std;

int main(void){
    int a,b,n,m;
    cin >> a >> b;
    m=b;
    for (int i=1;i<a;i++){
        cin >> n;
        m=m>n?m:n;
    }
    if (b==m){
        cout << "S";
    }
    else{
        cout << "N";
    }
    return 0;
}