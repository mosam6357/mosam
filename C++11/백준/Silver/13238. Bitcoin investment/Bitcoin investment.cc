#include <iostream>
using namespace std;

int main(){
    int a,max = 0;
    cin >> a;
    int aa[a];
    for (int i=0;i<a;i++){
        cin >> aa[i];
    }
    for (int i=0;i<a;i++){
        for (int j=i;j<a;j++){
            int x = aa[j]-aa[i];
            max = max>x?max:x;
        }
    }
    cout << max;
}