#include <iostream>
using namespace std;

int main(){
    int a,b;
    cin >> a >> b;
    int min = b;
    if(a>=5){
        min-=500;
    }
    if(a>=10){
        min = min<(b/10)*9?min:(b/10)*9;
    }
    if(a>=15){
        min = min<b-2000?min:b-2000;
    }
    if(a>=20){
        min = min<(b/4)*3?min:(b/4)*3;
    }
    min = min>0?min:0;
    cout << min;
}