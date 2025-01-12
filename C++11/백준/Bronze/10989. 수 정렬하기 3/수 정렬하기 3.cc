#include <iostream>
using namespace std;

int main(){
    int a,b;
    int aa[10001] = {0,};
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b;
        aa[b-1]++;
    }
    for (int i=0;i<10000;i++){
        for (int j=0;j<aa[i];j++){
            cout << i+1 << '\n';
        }
    }
}