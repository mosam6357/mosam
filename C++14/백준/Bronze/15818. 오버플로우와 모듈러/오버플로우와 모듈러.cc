#include <iostream>
using namespace std;

int main(void){
    long a,b,c,n=1;
    cin >> a >> b;
    for (int i=0;i<a;i++){
        cin >> c;
        n*=c%b;
        n=n%b;
    }
    cout << n;
    return 0;
}