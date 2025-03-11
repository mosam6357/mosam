#include <iostream>
using namespace std;

int main(){
    int a;
    while(true){
        cin >> a;
        if(a==0){break;}
        cout << a << " => " << a*(a-1)+1 << endl;
    }
    return 0;
}