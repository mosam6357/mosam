#include <iostream>
using namespace std;

int main(){
    int a,b,t,c,d,sum=0;
    cin >> a>>b>>t;
    for (int i=0;i<t;i++){
        cin >> c >> d;
        sum+=a*c>b*d?a*c:b*d;
    }
    cout << sum;
}