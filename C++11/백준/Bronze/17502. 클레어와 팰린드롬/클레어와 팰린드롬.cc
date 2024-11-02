#include <iostream>
using namespace std;

int main(){
    int a;
    cin>>a;
    string b;
    string c;
    cin >>b;
    for (int i =0; i<a; i++){
        c+=b[b.length()-1-i];
    }
    for (int i = 0; i<a; i++){
        if(b[i]=='?'){
            if(c[i]=='?'){
                cout<<'a';
            }
            else{
                cout<<c[i];
            }
        }
        else{
            cout<<b[i];
        }
    }
}