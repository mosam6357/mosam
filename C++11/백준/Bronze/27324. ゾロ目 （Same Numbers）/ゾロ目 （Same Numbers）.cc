#include <iostream>
using namespace std;

int main(void){
    int a;
    cin >> a;
    if (a/10==a%10){
        cout << 1;
    }
    else{
        cout << 0;
    }
    return 0;
}