#include <iostream>
#include <math.h>
using namespace std;
int main(){
    double a[2];
    double b[2];
    cin >> a[0] >> a[1] >> b[0] >> b[1];
    double c1 = a[0]/a[1];
    double c2 = (b[0]*b[0]*M_PI)/b[1];
    if(c1>c2){
        cout << "Slice of pizza";
    }
    else{
        cout << "Whole pizza";
    }
}