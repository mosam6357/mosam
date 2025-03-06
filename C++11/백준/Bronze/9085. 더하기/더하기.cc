#include <iostream>
using namespace std;

int main(void){
    int a,b,n;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b;
        int sum=0;
        for (int j=0;j<b;j++){
            cin >> n;
            sum+=n;
        }
        cout << sum << endl;
    }
    return 0;
}