#include <iostream>
using namespace std;

int main(){
    int a,b,min = 0;
    while(true){
        cin >> a >> b;
        if(a==0 && b==0)break;
        min = 30*a+40*b;
        min = min<35*a+30*b?min:35*a+30*b;
        min = min<40*a+20*b?min:40*a+20*b;
        cout << min << endl;
    }
}