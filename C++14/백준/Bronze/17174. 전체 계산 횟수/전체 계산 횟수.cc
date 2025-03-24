#include <iostream>
using namespace std;

int main(void){
    int a,b;
    cin >> a >> b;
    int total=a;
    while(a>=b){
        a/=b;
        total+=a;
    }
    cout << total;
    return 0;
}