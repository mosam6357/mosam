#include <iostream>
using namespace std;

int main(){
    double a,b,c,d=0;
    int q;
    cin >> a >> q;
    for (int i=0;i<q;i++){
        cin >> b>>c;
        d+=b*c;
    }
    cout << fixed;
    cout.precision(7);
    cout << a*d;
}