#include <iostream>
using namespace std;

int main(){
    int a,x;
    cin >> a;
    int aa[a] = {0,};
    for (int i=0;i<2*a-1;i++){
        cin >> x;
        aa[x-1]++;
    }
    for (int i=0;i<a;i++){
        if(aa[i]==1){
            cout << i+1;
            break;
        }
    }
    return 0;
}