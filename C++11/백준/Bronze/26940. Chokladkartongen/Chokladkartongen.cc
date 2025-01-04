#include <iostream>
using namespace std;

int main(){
    int a,b,c,cnt = 0;
    cin >> a >> b;
    for (int i=0;i<a-1;i++){
        cin >> c;
        if (c>b)cnt++;
        b=c;
    }
    cout << cnt;
}