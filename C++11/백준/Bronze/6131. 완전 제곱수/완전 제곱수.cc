#include <iostream>
using namespace std;

int main(void){
    int a,cnt = 0;
    cin >> a;
    for (int i=2;i<1000;i++){
        for (int j=1;j<i;j++){
            if (i*i==j*j+a){
                cnt++;
            }
        }
    }
    cout << cnt;
}