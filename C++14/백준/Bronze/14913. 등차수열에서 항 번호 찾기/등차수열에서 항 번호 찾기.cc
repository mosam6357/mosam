#include <iostream>
using namespace std;

int main(void){
    int a,b,c;
    cin >> a >> b >> c;
    c-=a;
    if (c%b==0 && c/b+1>0){
        cout << c/b+1;
    }
    else{
        cout << 'X';
    }
    return 0;
}