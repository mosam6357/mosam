#include <iostream>
using namespace std;

int main(void){
    int a,b=0;
    for (int i=0;i<5;i++){
        cin >> a;
        b+=a;
    }
    cout << b;
    return 0;
}