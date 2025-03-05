#include <iostream>
using namespace std;

int main(void){
    int a,n,cnt = 0;
    cin >> a;
    for (int i=1;i<=a;i++){
        cin >> n;
        if (n!=i){
            cnt++;
        }
    }
    cout << cnt;
    return 0;
}