#include <iostream>
using namespace std;

int main(){
    int a,cnt = 0,x=1;
    cin >> a;
    char c[a+1];
    cin >> c;
    for (int i=0;i<a;i++){
        if(c[i]=='L'){
            if(x!=1){x--;}
        }
        else{
            if(x!=3){x++;}
            if(x==3){cnt++;}
        }
    }
    cout << cnt;
}