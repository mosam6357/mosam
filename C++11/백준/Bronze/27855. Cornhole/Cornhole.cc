#include <iostream>
using namespace std;

int main(){
    int a,b,c,d,e,f;
    cin >> a >> b >> c >> d;
    e = a*3+b;
    f = c*3+d;
    if(e==f){
        cout << "NO SCORE";
    }
    else{
        cout << (e>f?1:2) << " "<< (e>f?e-f:f-e);
    }
}