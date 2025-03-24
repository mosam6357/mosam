#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,b,total=0;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b;
        total+=b;
    }
    cout << total;
    return 0;
}