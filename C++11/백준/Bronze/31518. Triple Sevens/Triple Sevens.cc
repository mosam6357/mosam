#include <iostream>
using namespace std;

int main(){
    int a,cnt,ck;
    cin >> a;
    for (int i =0; i<3; i++){
        int b[a];
        ck=0;
        for (int j=0;j<a;j++){
            cin>>b[i];
            if(b[i]==7 && ck==0){
                ck=1;
                cnt+=1;
            }
        }
    }
    cout << (cnt==3?777:0);
}