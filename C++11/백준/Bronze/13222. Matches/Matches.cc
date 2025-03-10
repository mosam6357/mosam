#include <iostream>
using namespace std;

int main(void){
    int a,b,c,n;
    cin >> a >> b >> c;
    for (int i=0;i<a;i++){
        cin >> n;
        if(n*n<=b*b+c*c){
            cout << "YES" << endl;
        }
        else{
            cout << "NO" << endl;
        }
    }
    return 0;
}