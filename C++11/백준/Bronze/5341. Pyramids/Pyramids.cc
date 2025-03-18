#include <iostream>
using namespace std;

int main(void){
    while(true){
        int a;
        cin >> a;
        if (a==0){
            break;
        }
        else{
            cout << (a*(a+1))/2 << '\n';
        }
    }
    return 0;
}