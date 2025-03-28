#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,n=1;
    cin >> a;
    for (int i=1;i<a;i++){
        if (i>a-4){
            n*=i;
        }
    }
    cout << n/6;
    return 0;
}