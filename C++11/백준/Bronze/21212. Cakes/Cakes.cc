#include <iostream>
using namespace std;

int main(){
    int a,b,c,x,min=10000;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b>>c;
        x = c/b;
        min = min<x?min:x;
    }
    cout << min;
}