#include <iostream>
#include <string>
using namespace std;

int main(void){
    float n,a,b;
    cin >> n >> a >> b;
    if (a/b>=n){
        cout << 1;
    }
    else{
        cout << 0;
    }
    return 0;
}