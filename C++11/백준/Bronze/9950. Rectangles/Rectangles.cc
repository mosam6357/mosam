#include <iostream>
using namespace std;

int main(){
    int a,b,c;
    while(true){
        cin >> a >> b >> c;
        if(a==0 && b==0 && c==0){
            break;
        }
        if(a==0){
            cout << c/b<<" "<<b<<" "<<c<<endl;
        }
        else if(b==0){
            cout <<a<<" "<<c/a<<" "<<c<<endl;
        }
        else{
            cout <<a<<" "<<b<<" "<<a*b<<endl;
        }
    }
}