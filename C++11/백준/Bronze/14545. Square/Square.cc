#include <iostream>
using namespace std;

int main(void){
    int t,a;
    cin >> t;
    for (int i=0;i<t;i++){
        cin >> a;
        int total = 0;
        for (int j=1;j<=a;j++){
            total+=j*j;
        }
        cout << total << '\n';
    }
    return 0;
}