#include <iostream>
using namespace std;

int main(void){
    int a,b=1;
    cin >> a;
    while(a>b){
        b*=2;
    }
    if(a==b){
        cout << 1;
    }
    else{
        cout << 0;
    }
    return 0;
}