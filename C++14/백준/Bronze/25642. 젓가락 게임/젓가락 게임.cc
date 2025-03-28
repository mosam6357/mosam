#include <iostream>
using namespace std;

int main(void){
    int a,b;
    cin >> a >> b;
    while(true){
        b+=a;
        if (b>=5){
            cout << "yt";
            break;
        }
        a+=b;
        if (a>=5){
            cout << "yj";
            break;
        }
    }
    return 0;
}