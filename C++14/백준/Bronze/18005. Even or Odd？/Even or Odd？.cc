#include <iostream>
using namespace std;

int main(void){
    int a;
    cin >> a;
    if (a%2==0){
        int b = a/2;
        if (b%2==0){
            cout << 2;
        }
        else{
            cout << 1;
        }
    }
    else{
        cout << 0;
    }
    return 0;
}