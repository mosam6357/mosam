#include <iostream>
using namespace std;

int main(void){
    int n,c,t;
    cin >> n >> c >> t;
    for (int i=0;i<t;i++){
        int a,b;
        cin >> a >> b;
        if (c==a){
            c=b;
        }
        else if(c==b){
            c=a;
        }
    }
    cout << c;
    return 0;
}