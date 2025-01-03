#include <iostream>
using namespace std;

int main(){
    int q;
    cin >> q;
    double a=q,b,s=0;
    for (int i=0;i<q;i++){
        cin >> b;
        if (b==-1)a--;
        else{
            s+=b;
        }
    }
    printf("%lf",s/a);
}