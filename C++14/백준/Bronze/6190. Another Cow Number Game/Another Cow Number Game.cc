#include <iostream>
using namespace std;

int main(void){
    long a,cnt=0;
    cin >> a;
    while(a!=1){
        if (a%2==0){
            a = a/2;
        }
        else{
            a = a*3+1;
        }
        cnt++;
    }
    cout << cnt;
    return 0;
}