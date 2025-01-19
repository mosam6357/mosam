#include <iostream>
using namespace std;

int main(){
    int a,b,cnt = 0;
    cin >> a >> b;
    while(a<b){
        if (a%3==0)a++;
        else if(a%3==1)a*=2;
        else a*=3;
        cnt++;
    }
    cout << cnt;
}