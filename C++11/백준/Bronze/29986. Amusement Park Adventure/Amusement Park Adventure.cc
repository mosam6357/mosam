#include <iostream>
using namespace std;

int main(){
    int a,b,c;
    int cnt = 0;
    cin >> a>> b;
    for (int i =0; i<a; i++){
        cin>>c;
        if(c<=b)cnt++;
    }
    cout<<cnt;
}