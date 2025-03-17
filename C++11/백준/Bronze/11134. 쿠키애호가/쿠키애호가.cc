#include <iostream>
using namespace std;

int main(void){
    int t,a,b;
    cin >> t;
    for (int i=0;i<t;i++){
        cin >> a >> b;
        while(a%b!=0){
            a++;
        }
        cout << a/b << '\n';
    }
    return 0;
}