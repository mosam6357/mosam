#include <iostream>
using namespace std;

int main(){
    int a;
    double b,c,sum=0;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b >> c;
        sum+=b*c;
    }
    printf("%lf",sum);
}