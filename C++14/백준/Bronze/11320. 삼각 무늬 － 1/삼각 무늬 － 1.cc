#include <iostream>
using namespace std;

int main(void){
    long a,b,c;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b >> c;
        cout << (b*b)/(c*c) << endl;
    }
    return 0;
}