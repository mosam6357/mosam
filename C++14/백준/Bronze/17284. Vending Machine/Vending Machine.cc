#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,b=5000,n;
    while(cin >> a){
        if (a==1){
            n=500;
        }
        else if(a==2){
            n=800;
        }
        else{
            n=1000;
        }
        b-=n;
    }
    cout << b;
    return 0;
}