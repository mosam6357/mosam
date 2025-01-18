#include <iostream>
using namespace std;

int main(){
    int a,b,lim,cnt1=0,cnt2=0;
    cin >> a >> lim;
    for (int i=0;i<a;i++){
        cin >> b;
        if (lim>b)cnt1++;
        else if(b>lim)cnt2++;
    }
    if(cnt1>cnt2){cout<<1;}
    else if(cnt1==cnt2){cout<<0;}
    else{
        cout << 2;
    }
}