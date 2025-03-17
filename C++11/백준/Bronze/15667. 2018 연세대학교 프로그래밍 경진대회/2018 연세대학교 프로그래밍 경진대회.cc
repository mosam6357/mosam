#include <iostream>
using namespace std;

int main(void){
    int a;
    cin >> a;
    for (int i=1;i<101;i++){
        if (a==i*i+i+1){
            cout << i;
            break;
        }
    }
    return 0;
}