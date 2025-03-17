#include <iostream>
using namespace std;

int main(void){
    int a,total = 0;
    cin >> a;
    for(int i=1;i<=a;i++){
        if (a%i==0){
            total+=i;
        }
    }
    cout << total*5-24;
    return 0;
}