#include <iostream>
using namespace std;

int main(){
    int a,b,c;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b >> c;
        cout << b << " " << (c*(c+1))/2+c << endl;
    }
}