#include <iostream>
using namespace std;

int main(void){
    int a,b,c,d,e,f,max=-1,t;
    cin >> a >> b >> c >> t;
    for (int i=0;i<t;i++){
        int total = 0;
        for (int j=0;j<3;j++){
            cin >> d >> e >> f;
            total+=a*d+b*e+c*f;
        }
        max = max>total?max:total;
    }
    cout << max;
    return 0;
}