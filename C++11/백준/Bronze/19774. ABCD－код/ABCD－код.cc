#include <iostream>
using namespace std;

int main(){
    int t,n;
    cin >> t;
    for (int i=0;i<t;i++){
        cin >> n;
        int a = n/1000;
        int b = n%1000/100;
        int c = n%100/10;
        int d = n%10;
        int p1 = a*10+b;
        p1*=p1;
        int p2 = c*10+d;
        p2*=p2;
        if((p1+p2)%7==1){
            cout << "YES" << endl;
        }
        else{
            cout << "NO" << endl;
        }
    }
}