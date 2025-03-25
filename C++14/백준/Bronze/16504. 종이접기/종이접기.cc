#include <iostream>
using namespace std;

int main(void){
    long a,b,total=0;
    cin >> a;
    for (int i=0;i<a*a;i++){
        cin >> b;
        total+=b;
    }
    cout << total;
    return 0;
}