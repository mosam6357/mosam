#include <iostream>
using namespace std;

int main(void){
    int a,total = 0;
    cin >> a;
    for (int i=1;i<=a;i++){
        total += i*(i+1)*3/2;
    }
    cout << total;
    return 0;
}