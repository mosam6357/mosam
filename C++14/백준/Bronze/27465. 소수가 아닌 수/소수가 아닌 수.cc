#include <iostream>
using namespace std;

int main(void){
    int a;
    cin >> a;
    if (a<=2){
        a=4;
    }
    if (a%2!=0){
        a++;
    }
    cout << a;
    return 0;
}