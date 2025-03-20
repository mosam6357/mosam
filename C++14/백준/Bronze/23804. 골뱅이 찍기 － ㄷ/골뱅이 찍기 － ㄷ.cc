#include <iostream>
using namespace std;

int main(void){
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    int a;
    cin >> a;
    for (int i=0;i<5;i++){
        for (int j=0;j<a;j++){
            int n=a;
            if (i==0 || i==4){
                n *= 5;
            }
            for (int k=0;k<n;k++){
                cout << '@';
            }
            cout << '\n';
        }
    }
    return 0;
}