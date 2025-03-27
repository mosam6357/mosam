#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,n,sum=0,cnt=0;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> n;
        if (n==0){
            cnt++;
        }
        sum+=n;
    }
    if (cnt*2>=a){
        cout << "INVALID";
    }
    else if(sum>0){
        cout << "APPROVED";
    }
    else{
        cout << "REJECTED";
    }
    return 0;
}