#include <iostream>
using namespace std;

int main(void){
    int a,cnt = 1;
    cin >> a;
    while(a!=1){
        if (a%2==0){
            a/=2;
        }
        else{
            a = a*3+1;
        }
        cnt++;
    }
    cout << cnt;
    return 0;
}