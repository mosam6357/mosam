#include <iostream>
#include <cmath>
using namespace std;

int main(){
    int a,b,s=0,m=0;
    cin >> a >> b;
    for (int i=a;i<=b;i++){
        if (sqrt(i)-int(sqrt(i))==0){
            s+=i;
            if(m==0){
                m=i;
            }
        }
    }
    if(s==0){
        cout << -1;
    }
    else{
        cout << s << endl << m;
    }
    return 0;
}