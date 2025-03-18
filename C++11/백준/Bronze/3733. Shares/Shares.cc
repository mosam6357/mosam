#include <iostream>
using namespace std;

int main(void){
    int a,b;
    while(cin >> a >> b){
        cout << b/(a+1) << '\n';
    }
    return 0;
}