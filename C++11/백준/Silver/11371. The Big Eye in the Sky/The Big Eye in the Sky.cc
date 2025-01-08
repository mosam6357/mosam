#include <iostream>
#include <math.h>
using namespace std;

int main(){
    float x,y;
    while(true){
        cin >> x >> y;
        if (x==0 && y==0)break;
        if (x==0){
            cout << "90\n";
        }
        else{
            cout << round(180*atan(y/x)/M_PI) << endl;
        }
    }
}