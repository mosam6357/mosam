#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,b,cnt=0;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b;
        if (b%2==1){
            cnt++;
        }
    }
    cout << cnt;
    return 0;
}