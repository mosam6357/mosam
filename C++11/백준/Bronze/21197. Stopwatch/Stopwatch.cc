#include <iostream>
using namespace std;

int main(){
    int a,b,c,s=0;
    cin >> a;
    if (a%2) cout << "still running";
    else{
        for (int i=0;i<a/2;i++){
            cin >> b>>c;
            s+=c-b;
        }
        cout << s;
    }
}