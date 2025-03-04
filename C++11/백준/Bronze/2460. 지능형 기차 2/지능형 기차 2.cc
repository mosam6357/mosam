#include <iostream>
using namespace std;

int main(void){
    int a,b,p=0,max=0;
    for (int i=0;i<10;i++){
        cin >> a >> b;
        p+=b-a;
        max = max>p?max:p;
    }
    cout << max;
    return 0;
}