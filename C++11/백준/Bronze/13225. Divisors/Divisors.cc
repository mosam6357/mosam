#include <iostream>
using namespace std;

int main(){
    int a,n;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> n;
        int cnt = 0;
        for (int j=1;j<=n;j++){
            if(n%j==0)cnt++;
        }
        cout << n << " " << cnt <<endl;
    }
}