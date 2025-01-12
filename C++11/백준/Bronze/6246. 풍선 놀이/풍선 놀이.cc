#include <iostream>
using namespace std;

int main(){
    int a,b,c,d,cnt=0;
    cin >> a >> b;
    int aa[a] = {0,};
    for (int i=0;i<b;i++){
        cin >> c >> d;
        for (int j=c-1;j<a;j+=d){
            aa[j]=1;
        }
    }
    for (int i=0;i<a;i++){
        if(aa[i]==0)cnt++;
    }
    cout << cnt;
}