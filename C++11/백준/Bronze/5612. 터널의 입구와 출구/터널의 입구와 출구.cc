#include <iostream>
using namespace std;

int main(void){
    int t,n,m;
    cin >> t >> n;
    m = n;
    for (int i=0;i<t;i++){
        int a,b;
        cin >> a >> b;
        n += a-b;
        if (n<0){
            m=0;
            break;
        }
        m = m>n?m:n;
    }
    cout << m;
    return 0;
}