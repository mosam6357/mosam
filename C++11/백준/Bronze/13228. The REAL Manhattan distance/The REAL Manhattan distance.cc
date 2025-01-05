#include <iostream>
#include <cstdlib>
using namespace std;

int main(){
    int a;
    cin >> a;
    for (int i=0;i<a;i++){
        int aa[6];
        for (int j =0;j<6;j++){
            cin >> aa[j];
        }
        cout << aa[2]+aa[5]+abs(aa[3]-aa[0])+abs(aa[4]-aa[1])<<endl;
    }
}