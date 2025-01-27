#include <iostream>
using namespace std;

int main(){
    int a,b,c,d;
    cin >> a>> b>>c>>d;
    if(b<=a){
        cout << b*c;
    }
    else{
        cout << a*c+(b-a)*d;
    }
}