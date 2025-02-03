#include <iostream>
#include <cmath>
using namespace std;

int main(){
    int a;
    cin >> a;
    for (int i=0;i<2*a-1;i++){
        for (int j=0;j<a-abs(a-(i+1));j++){
            cout << "*";
        }
        cout << endl;
    }
    return 0;
}