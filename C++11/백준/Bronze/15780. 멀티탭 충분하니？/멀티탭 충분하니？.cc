#include <iostream>
using namespace std;

int main(){
    int p,a,s=0,x;
    cin >> p >> a;
    for (int i=0;i<a;i++){
        cin >> x;
        s += (x+1)/2;
    }
    if(s>=p){
        cout << "YES";
    }
    else{
        cout << "NO";
    }
}