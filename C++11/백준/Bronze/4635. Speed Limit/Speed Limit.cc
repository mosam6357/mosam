#include <iostream>
using namespace std;

int main(){
    int a,b,c;
    while(true){
        cin >> a;
        if (a==-1)break;
        int s = 0;
        int ans = 0;
        for (int i=0;i<a;i++){
            cin >> b >> c;
            ans += b*(c-s);
            s+=c-s;
        }
        cout << ans <<" miles" << endl;
    }
}